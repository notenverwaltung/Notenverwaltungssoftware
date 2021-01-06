using MvvmCross.Platforms.Wpf.Presenters.Attributes;
using MvvmCross.Platforms.Wpf.Views;
using System.Windows;
using System.Windows.Input;

namespace GradeManager.WPF.UI.Views
{
    /// <summary>
    /// MainWindow.
    /// </summary>
    /// <seealso cref="MvvmCross.Platforms.Wpf.Views.MvxWindow" />
    /// <seealso cref="System.Windows.Markup.IComponentConnector" />
    [MvxWindowPresentation(Modal = false)]
    public partial class MainWindow : MvxWindow
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MainWindow" /> class.
        /// </summary>
        public MainWindow()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Handles the MouseLeftButtonDown event of the GridTop control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">
        /// The <see cref="MouseButtonEventArgs" /> instance containing the event data.
        /// </param>
        private void GridTop_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        /// <summary>
        /// Handles the Click event of the WindowClose control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">
        /// The <see cref="RoutedEventArgs" /> instance containing the event data.
        /// </param>
        private void WindowClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        /// <summary>
        /// Handles the Click event of the WindowMaximize control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">
        /// The <see cref="RoutedEventArgs" /> instance containing the event data.
        /// </param>
        private void WindowMaximize_Click(object sender, RoutedEventArgs e)
        {
            if (this.WindowState == WindowState.Maximized) { this.WindowState = WindowState.Normal; }
            else if (this.WindowState == WindowState.Normal) { this.WindowState = WindowState.Maximized; }
        }

        /// <summary>
        /// Handles the Click event of the WindowMinimize control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">
        /// The <see cref="RoutedEventArgs" /> instance containing the event data.
        /// </param>
        private void WindowMinimize_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }
    }
}