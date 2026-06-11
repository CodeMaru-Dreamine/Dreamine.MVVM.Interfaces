using System.Threading.Tasks;

namespace Dreamine.MVVM.Interfaces.Windows
{
    /// <summary>
    /// Provides dialog presentation services for ViewModels, decoupled from WPF MessageBox.
    /// </summary>
    public interface IDialogService
    {
        /// <summary>
        /// Displays an informational message dialog.
        /// </summary>
        /// <param name="message">The message to display.</param>
        /// <param name="title">The dialog title.</param>
        void ShowMessage(string message, string title = "");

        /// <summary>
        /// Displays an error message dialog.
        /// </summary>
        /// <param name="message">The error message to display.</param>
        /// <param name="title">The dialog title.</param>
        void ShowError(string message, string title = "Error");

        /// <summary>
        /// Displays a yes/no confirmation dialog.
        /// </summary>
        /// <param name="message">The question to display.</param>
        /// <param name="title">The dialog title.</param>
        /// <returns><c>true</c> if the user confirmed; otherwise <c>false</c>.</returns>
        bool Confirm(string message, string title = "Confirm");

        /// <summary>
        /// Asynchronously displays an informational message dialog.
        /// </summary>
        /// <param name="message">The message to display.</param>
        /// <param name="title">The dialog title.</param>
        Task ShowMessageAsync(string message, string title = "");

        /// <summary>
        /// Asynchronously displays a yes/no confirmation dialog.
        /// </summary>
        /// <param name="message">The question to display.</param>
        /// <param name="title">The dialog title.</param>
        /// <returns><c>true</c> if the user confirmed; otherwise <c>false</c>.</returns>
        Task<bool> ConfirmAsync(string message, string title = "Confirm");
    }
}
