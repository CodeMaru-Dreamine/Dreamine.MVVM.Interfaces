using System.Threading.Tasks;

namespace Dreamine.MVVM.Interfaces.Windows
{
    /// <summary>
    /// \if KO
    /// <para>I Dialog Service 기능과 관련 상태를 캡슐화합니다.</para>
    /// \endif
    /// \if EN
    /// <para>Provides dialog presentation services for ViewModels, decoupled from WPF MessageBox.</para>
    /// \endif
    /// </summary>
    public interface IDialogService
    {
        /// <summary>
        /// \if KO
        /// <para>Show Message 작업을 수행합니다.</para>
        /// \endif
        /// \if EN
        /// <para>Displays an informational message dialog.</para>
        /// \endif
        /// </summary>
        /// <param name="message">
        /// \if KO
        /// <para>처리할 메시지입니다.</para>
        /// \endif
        /// \if EN
        /// <para>The message to display.</para>
        /// \endif
        /// </param>
        /// <param name="title">
        /// \if KO
        /// <para>title에 사용할 <see cref="string"/> 값입니다.</para>
        /// \endif
        /// \if EN
        /// <para>The dialog title.</para>
        /// \endif
        /// </param>
        void ShowMessage(string message, string title = "");

        /// <summary>
        /// \if KO
        /// <para>Show Error 작업을 수행합니다.</para>
        /// \endif
        /// \if EN
        /// <para>Displays an error message dialog.</para>
        /// \endif
        /// </summary>
        /// <param name="message">
        /// \if KO
        /// <para>처리할 메시지입니다.</para>
        /// \endif
        /// \if EN
        /// <para>The error message to display.</para>
        /// \endif
        /// </param>
        /// <param name="title">
        /// \if KO
        /// <para>title에 사용할 <see cref="string"/> 값입니다.</para>
        /// \endif
        /// \if EN
        /// <para>The dialog title.</para>
        /// \endif
        /// </param>
        void ShowError(string message, string title = "Error");

        /// <summary>
        /// \if KO
        /// <para>Confirm 작업을 수행합니다.</para>
        /// \endif
        /// \if EN
        /// <para>Displays a yes/no confirmation dialog.</para>
        /// \endif
        /// </summary>
        /// <param name="message">
        /// \if KO
        /// <para>처리할 메시지입니다.</para>
        /// \endif
        /// \if EN
        /// <para>The question to display.</para>
        /// \endif
        /// </param>
        /// <param name="title">
        /// \if KO
        /// <para>title에 사용할 <see cref="string"/> 값입니다.</para>
        /// \endif
        /// \if EN
        /// <para>The dialog title.</para>
        /// \endif
        /// </param>
        /// <returns>
        /// \if KO
        /// <para>Confirm 조건이 충족되면 <see langword="true"/>이고, 그렇지 않으면 <see langword="false"/>입니다.</para>
        /// \endif
        /// \if EN
        /// <para><c>true</c> if the user confirmed; otherwise <c>false</c>.</para>
        /// \endif
        /// </returns>
        bool Confirm(string message, string title = "Confirm");

        /// <summary>
        /// \if KO
        /// <para>Show Message Async 작업을 수행합니다.</para>
        /// \endif
        /// \if EN
        /// <para>Asynchronously displays an informational message dialog.</para>
        /// \endif
        /// </summary>
        /// <param name="message">
        /// \if KO
        /// <para>처리할 메시지입니다.</para>
        /// \endif
        /// \if EN
        /// <para>The message to display.</para>
        /// \endif
        /// </param>
        /// <param name="title">
        /// \if KO
        /// <para>title에 사용할 <see cref="string"/> 값입니다.</para>
        /// \endif
        /// \if EN
        /// <para>The dialog title.</para>
        /// \endif
        /// </param>
        /// <returns>
        /// \if KO
        /// <para>Show Message Async 작업에서 생성한 <see cref="Task"/> 결과입니다.</para>
        /// \endif
        /// \if EN
        /// <para>The <see cref="Task"/> result produced by the show message async operation.</para>
        /// \endif
        /// </returns>
        Task ShowMessageAsync(string message, string title = "");

        /// <summary>
        /// \if KO
        /// <para>Confirm Async 작업을 수행합니다.</para>
        /// \endif
        /// \if EN
        /// <para>Asynchronously displays a yes/no confirmation dialog.</para>
        /// \endif
        /// </summary>
        /// <param name="message">
        /// \if KO
        /// <para>처리할 메시지입니다.</para>
        /// \endif
        /// \if EN
        /// <para>The question to display.</para>
        /// \endif
        /// </param>
        /// <param name="title">
        /// \if KO
        /// <para>title에 사용할 <see cref="string"/> 값입니다.</para>
        /// \endif
        /// \if EN
        /// <para>The dialog title.</para>
        /// \endif
        /// </param>
        /// <returns>
        /// \if KO
        /// <para>Confirm Async 작업에서 생성한 <c>Task&lt;bool&gt;</c> 결과입니다.</para>
        /// \endif
        /// \if EN
        /// <para><c>true</c> if the user confirmed; otherwise <c>false</c>.</para>
        /// \endif
        /// </returns>
        Task<bool> ConfirmAsync(string message, string title = "Confirm");
    }
}
