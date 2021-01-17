using MvvmCross.Commands;
using System;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Media;

namespace Notenverwaltung.WPF.UI.Services
{
    /// <summary>
    /// Druck Service
    /// TODO: fix prints blank paper
    /// </summary>
    /// <seealso cref="Notenverwaltung.WPF.UI.Services.IPrintService" />
    /// <seealso cref="MvvmCross.Commands.IMvxCommand" />
    public class PrintService : IPrintService, IMvxCommand
    {
        #region Variables

        /// <summary>
        /// The print dialog
        /// </summary>
        private PrintDialog printDialog;

        /// <summary>
        /// Gets the print command.
        /// </summary>
        /// <value>The print command.</value>
        public static IMvxCommand PrintCommand { get; } = new PrintService();

        /// <summary>
        /// Occurs when changes occur that affect whether or not the command should
        /// execute.
        /// </summary>
        public event EventHandler CanExecuteChanged;

        #endregion Variables

        /// <summary>
        /// Initializes a new instance of the <see cref="PrintService" /> class.
        /// </summary>
        public PrintService()
        {
            printDialog = new PrintDialog();
        }

        #region InterfaceMethods

        public void PrintDocument(DocumentPaginator document, string description = "Notenverwaltung-DruckService")
        {
            if (ShowDialog())
                printDialog.PrintDocument(document, description);
        }

        public void PrintVisual(Visual visual, string description = "Notenverwaltung-DruckService")
        {
            if (ShowDialog())
                printDialog.PrintVisual(visual, description);
        }

        public bool ShowDialog()
        {
            Nullable<Boolean> print = printDialog.ShowDialog();

            return (bool)print;
        }

        #endregion InterfaceMethods

        #region CommandMethods

        /// <summary>
        /// Determines whether this instance can execute.
        /// </summary>
        /// <returns>
        /// <c>true</c> if this instance can execute; otherwise, <c>false</c>.
        /// </returns>
        public bool CanExecute()
        {
            return false;
        }

        /// <summary>
        /// Defines the method that determines whether the command can execute in its
        /// current state.
        /// </summary>
        /// <param name="parameter">
        /// Data used by the command. If the command does not require data to be passed,
        /// this object can be set to <see langword="null" />.
        /// </param>
        /// <returns>
        /// <see langword="true" /> if this command can be executed; otherwise, <see
        /// langword="false" />.
        /// </returns>
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Dispose()
        {
            if (printDialog != null)
            {
                //Dialog.Dispose();
                printDialog = null;
            }
        }

        /// <summary>
        /// Can not be called because we should specify a holder or container.
        /// </summary>
        public void Execute()
        {
            throw new InvalidOperationException("You should pass a visual in command parameter.");
        }

        /// <summary>
        /// Defines the method to be called when the command is invoked.
        /// </summary>
        /// <param name="parameter">
        /// Data used by the command. If the command does not require data to be passed,
        /// this object can be set to <see langword="null" />.
        /// </param>
        /// <exception cref="InvalidCastException">
        /// Command parameter should be a content control.
        /// </exception>
        public void Execute(object parameter)
        {
            var visual = GetVisual(parameter);
            var document = GetDocument(parameter);

            if (visual == null && document == null) throw new InvalidCastException("Command parameter should be a content control.");

            if (visual != null)
            {
                PrintVisual(visual);
            }
            else if (document != null)
            {
                PrintDocument(document);
            }
        }

        public void RaiseCanExecuteChanged()

        {
            CanExecuteChanged?.Invoke(this, EventArgs.Empty);
        }

        #endregion CommandMethods

        #region PrivateMethods

        internal static DocumentPaginator GetDocument(object parameter)
        {
            var documentPaginator = parameter as DocumentPaginator;

            return documentPaginator;
        }

        internal static Visual GetVisual(object parameter)
        {
            var visual = parameter as Visual;

            return visual;
        }

        #endregion PrivateMethods
    }
}