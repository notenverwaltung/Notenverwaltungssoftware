using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace GradeManager.WPF.UI.Region
{
    /// <summary>
    /// Helper class to create containers. It also define attached properties.
    /// </summary>
    public static class MvxContainer
    {
        public static readonly DependencyProperty HeaderProperty =
            DependencyProperty.RegisterAttached("Header", typeof(object), typeof(MvxContainer),
                new UIPropertyMetadata(null));

        public static readonly DependencyProperty HolderTypeProperty =
            DependencyProperty.RegisterAttached("HolderType", typeof(Type), typeof(MvxContainer),
                new PropertyMetadata(null));

        public static readonly DependencyProperty IdProperty =
            DependencyProperty.RegisterAttached("Id", typeof(string), typeof(MvxContainer),
                new PropertyMetadata("", IdChanged));

        internal static readonly DependencyProperty HasClosingActionProperty =
            DependencyProperty.RegisterAttached("HasClosingAction", typeof(bool), typeof(MvxContainer),
                new PropertyMetadata(false));

        internal static readonly DependencyProperty HolderHistoryProperty =
            DependencyProperty.RegisterAttached("HolderHistory", typeof(Stack<FrameworkElement>), typeof(MvxContainer),
                new PropertyMetadata(null));

        private static readonly Dictionary<string, WeakReference<ItemsControl>> containers = new Dictionary<string, WeakReference<ItemsControl>>();

        public static ItemsControl GetContainerById(string id)
        {
            ItemsControl container = null;
            if (containers.TryGetValue(id, out WeakReference<ItemsControl> reference))
                reference.TryGetTarget(out container);
            return container;
        }

        public static List<ItemsControl> GetContainers()
        {
            var items = new List<ItemsControl>();
            var deadItems = new List<string>();
            foreach (var item in containers)
            {
                if (item.Value.TryGetTarget(out ItemsControl container)) items.Add(container);
                else deadItems.Add(item.Key);
            }
            foreach (var item in deadItems) containers.Remove(item);
            return items;
        }

        public static ItemsControl GetFirstContainer()
        {
            foreach (var item in containers)
                if (item.Value.TryGetTarget(out ItemsControl container)) return container;
            return null;
        }

        public static object GetHeader(DependencyObject obj) => obj.GetValue(HeaderProperty);

        public static Type GetHolderType(DependencyObject obj) => (Type)obj.GetValue(HolderTypeProperty);

        public static string GetId(ItemsControl obj) => (string)obj.GetValue(IdProperty);

        public static void SetHeader(DependencyObject obj, object value) => obj.SetValue(HeaderProperty, value);

        public static void SetHolderType(DependencyObject obj, Type value) => obj.SetValue(HolderTypeProperty, value);

        public static void SetId(ItemsControl obj, string value) => obj.SetValue(IdProperty, value);

        internal static bool GetHasClosingAction(ContentControl holder) => (bool)holder.GetValue(HasClosingActionProperty);

        internal static Stack<FrameworkElement> GetHolderHistory(ContentControl holder) => (Stack<FrameworkElement>)holder.GetValue(HolderHistoryProperty);

        internal static void SetHasClosingAction(ContentControl holder, bool value) => holder.SetValue(HasClosingActionProperty, value);

        internal static void SetHolderHistory(ContentControl holder, Stack<FrameworkElement> value) => holder.SetValue(HolderHistoryProperty, value);

        private static void IdChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var oldVlue = e.OldValue as string;
            var newValue = e.NewValue as string;
            var c = d as ItemsControl;
            if (c == null) throw new InvalidCastException("The container must be an ItemsControl");
            if (!string.IsNullOrWhiteSpace(oldVlue)) containers.Remove(oldVlue);
            if (!string.IsNullOrWhiteSpace(newValue))
            {
                if (containers.TryGetValue(newValue, out WeakReference<ItemsControl> oldWeakRef))
                {
                    containers.Remove(newValue);
                    if (oldWeakRef.TryGetTarget(out ItemsControl oldItemsControl))
                        oldItemsControl.ClearValue(IdProperty);
                }
                containers.Add(newValue, new WeakReference<ItemsControl>(c));
            }
        }
    }
}