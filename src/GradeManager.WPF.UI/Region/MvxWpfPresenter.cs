namespace GradeManager.WPF.UI.Region
{
    using MvvmCross.Commands;
    using MvvmCross.Platforms.Wpf.Presenters;
    using MvvmCross.Platforms.Wpf.Presenters.Attributes;
    using MvvmCross.Platforms.Wpf.Views;
    using MvvmCross.Presenters;
    using MvvmCross.ViewModels;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Controls.Primitives;
    using System.Windows.Data;

    /// <summary>
    /// MvxWpfPresenter.
    /// </summary>
    /// <seealso cref="MvvmCross.Platforms.Wpf.Presenters.MvxWpfViewPresenter" />
    public class MvxWpfPresenter : MvxWpfViewPresenter
    {
        private readonly ContentControl _root;

        public static IMvxCommand CloseHolderCommand { get; } = new MvxCloseHolderCommand();

        public static IMvxCommand CloseViewCommand { get; } = new MvxCloseViewCommand();

        /// <summary>
        /// Initializes a new instance of the <see cref="MvxWpfPresenter" /> class.
        /// </summary>
        public MvxWpfPresenter()
            : this(Application.Current?.MainWindow)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MvxWpfPresenter" /> class.
        /// </summary>
        /// <param name="root">The root.</param>
        public MvxWpfPresenter(ContentControl root)
            : base(root) => this._root = root;

        /// <summary>
        /// Closes the specified to close.
        /// </summary>
        /// <param name="toClose">To close.</param>
        /// <returns></returns>
        public override Task<bool> Close(IMvxViewModel toClose)
        {
            if (CloseViewModel(toClose).Result) return Task.FromResult(false);
            return base.Close(toClose);
        }

        /// <summary>
        /// First rgister <see cref="MvxWpfPresenterAttribute" /> in addition to the
        /// original MvvmCross attributes.
        /// </summary>
        public override void RegisterAttributeTypes()
        {
            this.AttributeTypesToActionsDictionary.Add(
                typeof(MvxWpfPresenterAttribute),
                new MvxPresentationAttributeAction()
                {
                    ShowAction = (viewType, attribute, request) => ShowView((MvxWpfPresenterAttribute)attribute, request),
                    CloseAction = (viewModel, attribute) => CloseViewModel(viewModel)
                });
            base.RegisterAttributeTypes();
        }

        /// <summary>
        /// Gets the view model.
        /// </summary>
        /// <param name="view">The view.</param>
        /// <returns></returns>
        static internal IMvxViewModel GetViewModel(FrameworkElement view)
        {
            if (view is IMvxWpfView mvx)
            {
                return mvx.ViewModel;
            }

            return view.DataContext as IMvxViewModel;
        }

        /// <summary>
        /// Shows the view active.
        /// </summary>
        /// <param name="attribute">The attribute.</param>
        /// <param name="request">The request.</param>
        /// <param name="container">The container.</param>
        protected virtual void ShowViewActive(MvxWpfPresenterAttribute attribute, MvxViewModelRequest request, ItemsControl container)
        {
            var selector = container as Selector;
            int i = (selector == null) ? selector.Items.Count - 1 : selector.SelectedIndex;
            if (i < 0) i = container.Items.Count - 1;
            if (i > -1 && container.Items[i] is ContentControl holder)
            {
                var view = WpfViewLoader.CreateView(request);
                GetHistory(holder).Push(view);
                SetViewInHolder(holder, view);
            }
            else ShowViewNew(attribute, request, container);
        }

        /// <summary>
        /// Shows the view new.
        /// </summary>
        /// <param name="attribute">The attribute.</param>
        /// <param name="request">The request.</param>
        /// <param name="container">The container.</param>
        protected virtual void ShowViewNew(MvxWpfPresenterAttribute attribute, MvxViewModelRequest request, ItemsControl container)
        {
            var view = WpfViewLoader.CreateView(request);
            var holder = CreateViewHolder(container);
            SetViewInHolder(holder, view);
            GetHistory(holder).Push(view);
            var i = container.Items.Add(holder);
            if (container is Selector selector) selector.SelectedIndex = i;
        }

        /// <summary>
        /// Shows the view new or exist.
        /// </summary>
        /// <param name="attribute">The attribute.</param>
        /// <param name="request">The request.</param>
        /// <param name="container">The container.</param>
        protected virtual void ShowViewNewOrExist(MvxWpfPresenterAttribute attribute, MvxViewModelRequest request, ItemsControl container)
        {
            ContentControl holder = null;
            var viewModel = (request as MvxViewModelInstanceRequest)?.ViewModelInstance;
            var viewId = attribute?.ViewId(viewModel);
            foreach (var item in container.Items.OfType<ContentControl>())
            {
                var view = item.Content as FrameworkElement;
                if (viewId == MvxWpfPresenterAttribute.GetViewId(view, request))
                {
                    holder = item;
                    break;
                }
            }
            if (holder != null)
            {
                if (container is Selector selector) selector.SelectedItem = holder;
                holder.BringIntoView();
            }
            else
            {
                ShowViewNew(attribute, request, container);
            }
        }

        /// <summary>
        /// Shows the view new or history exist.
        /// </summary>
        /// <param name="attribute">The attribute.</param>
        /// <param name="request">The request.</param>
        /// <param name="container">The container.</param>
        protected virtual void ShowViewNewOrHistoryExist(MvxWpfPresenterAttribute attribute, MvxViewModelRequest request, ItemsControl container)
        {
            ContentControl holder = null;
            var viewModel = (request as MvxViewModelInstanceRequest)?.ViewModelInstance;
            var viewId = attribute?.ViewId(viewModel);
            foreach (var item in container.Items.OfType<ContentControl>())
            {
                var history = MvxContainer.GetHolderHistory(item);
                foreach (var view in history)
                {
                    if (viewId == MvxWpfPresenterAttribute.GetViewId(view, request))
                    {
                        holder = item;
                        break;
                    }
                }
            }
            if (holder != null)
            {
                if (container is Selector selector) selector.SelectedItem = holder;
                holder.BringIntoView();
            }
            else
            {
                ShowViewNew(attribute, request, container);
            }
        }

        /// <summary>
        /// Shows the view with no container.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <param name="attribute">The attribute.</param>
        protected virtual void ShowViewWithNoContainer(MvxViewModelRequest request, MvxContentPresentationAttribute attribute)
        {
            var view = WpfViewLoader.CreateView(request);
            base.ShowContentView(view, new MvxContentPresentationAttribute(), request);
        }

        /// <summary>
        /// Closes the view.
        /// </summary>
        /// <param name="view">The view.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException">view</exception>
        /// <exception cref="InvalidOperationException">
        /// You can only close last opened view.
        /// </exception>
        private bool CloseView(FrameworkElement view)
        {
            if (view == null) throw new ArgumentNullException(nameof(view));
            var holder = view.Parent as ContentControl;
            if (holder != null)
            {
                var container = holder.Parent as ItemsControl;
                if (container != null)
                {
                    var history = MvxContainer.GetHolderHistory(holder);
                    if (history == null || history.Count < 2) //The holder contains only one view or no history
                    {
                        history?.Clear();
                        MvxContainer.SetHolderHistory(holder, null);
                        holder.Content = null;
                        container.Items.Remove(holder);
                        return true;
                    }
                    else
                    {
                        if (history.Peek() != view)
                            throw new InvalidOperationException("You can only close last opened view.");
                        history.Pop();
                        SetViewInHolder(holder, history.Peek());
                        return true;
                    }
                }
            }
            return false;
        }

        /// <summary>
        /// This will close the view containing a view model and return to previous view,
        /// or close the holder if it is the only view in the navigation stack.
        /// </summary>
        /// <param name="viewModel">The view model to be closed.</param>
        /// <returns>
        /// True if a view is found and closed, otherwise it will return false.
        /// </returns>
        private Task<bool> CloseViewModel(IMvxViewModel viewModel)
        {
            bool result = false;
            var view = GetView(viewModel);
            if (view != null) result = CloseView(view);
            return Task.FromResult(result);
        }

        /// <summary>
        /// Creates the view holder.
        /// </summary>
        /// <param name="container">The container.</param>
        /// <returns></returns>
        private ContentControl CreateViewHolder(ItemsControl container)
        {
            var t = MvxContainer.GetHolderType(container);
            ContentControl holder;
            if (container is TabControl tabControl)
            {
                TabItem tabHolder = (t == null) ? new TabItem() : Activator.CreateInstance(t) as TabItem;
                if (tabHolder == null) tabHolder = new TabItem();
                holder = tabHolder;
            }
            else
            {
                if (t == null) holder = new ContentControl();
                else holder = Activator.CreateInstance(t) as ContentControl;
            }
            return holder;
        }

        /// <summary>
        /// Gets the history.
        /// </summary>
        /// <param name="holder">The holder.</param>
        /// <returns></returns>
        private Stack<FrameworkElement> GetHistory(ContentControl holder)
        {
            var history = MvxContainer.GetHolderHistory(holder);
            if (history == null)
            {
                history = new Stack<FrameworkElement>();
                MvxContainer.SetHolderHistory(holder, history);
            }
            return history;
        }

        /// <summary>
        /// Gets the view.
        /// </summary>
        /// <param name="viewModel">The view model.</param>
        /// <returns></returns>
        private FrameworkElement GetView(IMvxViewModel viewModel)
        {
            foreach (var container in MvxContainer.GetContainers())
            {
                foreach (var holder in container.Items.OfType<ContentControl>())
                {
                    var control = holder.Content as FrameworkElement;
                    if (control is IMvxWpfView view && Equals(viewModel, view.ViewModel)) return control;
                    if (Equals(control.DataContext, viewModel)) return holder;
                }
            }
            return null;
        }

        /// <summary>
        /// Sets the view in holder.
        /// </summary>
        /// <param name="holder">The holder.</param>
        /// <param name="view">The view.</param>
        private void SetViewInHolder(ContentControl holder, FrameworkElement view)
        {
            holder.Content = view;
            if (holder is HeaderedContentControl headered)
            {
                var binding = new System.Windows.Data.Binding() { Source = view, Mode = BindingMode.TwoWay };
                binding.Path = new PropertyPath("(0)", MvxContainer.HeaderProperty);
                BindingOperations.SetBinding(headered, HeaderedContentControl.HeaderProperty, binding);
            }
        }

        /// <summary>
        /// Shows the view.
        /// </summary>
        /// <param name="attribute">The attribute.</param>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        private Task<bool> ShowView(MvxWpfPresenterAttribute attribute, MvxViewModelRequest request)
        {
            //Try to find items container.
            ItemsControl container = string.IsNullOrWhiteSpace(attribute?.ContainerId) ?
                MvxContainer.GetFirstContainer() : MvxContainer.GetContainerById(attribute?.ContainerId);
            if (container == null)// If no container found the switch to content view.
            {
                ShowViewWithNoContainer(request, new MvxContentPresentationAttribute());
                return Task.FromResult(true);
            }
            switch (attribute.ViewPosition)
            {
                case mvxViewPosition.Active:
                    ShowViewActive(attribute, request, container);
                    break;

                case mvxViewPosition.NewOrExsist:
                    ShowViewNewOrExist(attribute, request, container);
                    break;

                case mvxViewPosition.NewOrHistoryExsist:
                    ShowViewNewOrHistoryExist(attribute, request, container);
                    break;

                case mvxViewPosition.New:
                    ShowViewNew(attribute, request, container);
                    break;

                default:
                    break;
            }

            return Task.FromResult(true);
        }
    }
}