namespace GradeManager.WPF.UI.Region
{
    using MvvmCross.Presenters.Attributes;
    using MvvmCross.ViewModels;
    using System;
    using System.Linq;
    using System.Windows;

    /// <summary>
    /// MvxWpfPresenterAttribute.
    /// </summary>
    /// <seealso cref="MvvmCross.Presenters.Attributes.MvxBasePresentationAttribute" />
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = true)]
    public class MvxWpfPresenterAttribute : MvxBasePresentationAttribute
    {
        /// <summary>
        /// Gets or sets the container identifier.
        /// </summary>
        /// <value>The container identifier.</value>
        public string ContainerId { get; set; }

        /// <summary>
        /// Gets or sets the view identifier.
        /// </summary>
        /// <value>The view identifier.</value>
        public Func<object, string> ViewId { get; set; }

        /// <summary>
        /// Gets or sets the view position.
        /// </summary>
        /// <value>The view position.</value>
        public mvxViewPosition ViewPosition { get; set; }

        public MvxWpfPresenterAttribute(string containerId)
            : this(containerId, mvxViewPosition.New)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MvxWpfPresenterAttribute" />
        /// class.
        /// </summary>
        /// <param name="containerId">The container identifier.</param>
        /// <param name="viewPosition">The view position.</param>
        public MvxWpfPresenterAttribute(string containerId, mvxViewPosition viewPosition)
        {
            ContainerId = containerId;
            ViewPosition = viewPosition;
            ViewId = DefaultViewId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MvxWpfPresenterAttribute" />
        /// class.
        /// </summary>
        /// <param name="containerId">The container identifier.</param>
        /// <param name="viewPosition">The view position.</param>
        /// <param name="viewId">The view identifier.</param>
        public MvxWpfPresenterAttribute(string containerId, mvxViewPosition viewPosition, string viewId)
            : this(containerId, viewPosition)
        {
            ViewId = (a) => viewId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MvxWpfPresenterAttribute" />
        /// class.
        /// </summary>
        /// <param name="containerId">The container identifier.</param>
        /// <param name="viewPosition">The view position.</param>
        /// <param name="viewId">The view identifier.</param>
        public MvxWpfPresenterAttribute(string containerId, mvxViewPosition viewPosition, Func<object, string> viewId)
            : this(containerId, viewPosition)
        {
            ViewId = viewId;
        }

        /// <summary>
        /// Defaults the view identifier.
        /// </summary>
        /// <param name="view">The view.</param>
        /// <returns></returns>
        public static string DefaultViewId(object view) => view?.ToString();

        /// <summary>
        /// Gets the attribute.
        /// </summary>
        /// <param name="view">The view.</param>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public static MvxWpfPresenterAttribute GetAttribute(FrameworkElement view, MvxViewModelRequest request)
        {
            if (view is MvvmCross.Presenters.IMvxOverridePresentationAttribute mvxView)
            {
                if (mvxView.PresentationAttribute(request) is MvxWpfPresenterAttribute attr)
                {
                    return attr;
                }
            }

            return view.GetType().GetCustomAttributes(typeof(MvxWpfPresenterAttribute), true).FirstOrDefault() as MvxWpfPresenterAttribute;
        }

        /// <summary>
        /// Gets the view identifier.
        /// </summary>
        /// <param name="view">The view.</param>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public static string GetViewId(FrameworkElement view, MvxViewModelRequest request)
        {
            return GetAttribute(view, request)?.GetViewId(view);
        }

        /// <summary>
        /// Gets the view identifier.
        /// </summary>
        /// <param name="view">The view.</param>
        /// <returns></returns>
        public string GetViewId(FrameworkElement view)
        {
            if (view is MvvmCross.Views.IMvxView mvxView)
            {
                return ViewId(mvxView?.ViewModel ?? mvxView?.DataContext ?? view?.DataContext);
            }

            return ViewId(view?.DataContext);
        }
    }
}