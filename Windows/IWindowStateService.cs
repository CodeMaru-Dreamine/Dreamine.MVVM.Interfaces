using System;

namespace Dreamine.MVVM.Interfaces.Windows
{
    /// <summary>
    /// \if KO
    /// <para>I Window State Service 기능과 관련 상태를 캡슐화합니다.</para>
    /// \endif
    /// \if EN
    /// <para>Provides window open-state tracking.</para>
    /// \endif
    /// </summary>
    public interface IWindowStateService
    {
        /// <summary>
        /// \if KO
        /// <para>State Changed 상황이 발생할 때 알립니다.</para>
        /// \endif
        /// \if EN
        /// <para>Occurs when a window open-state changes.</para>
        /// \endif
        /// </summary>
        event EventHandler<WindowStateChangedEventArgs>? StateChanged;

        /// <summary>
        /// \if KO
        /// <para>Is Open 조건을 확인합니다.</para>
        /// \endif
        /// \if EN
        /// <para>Determines whether the window with the specified key is open.</para>
        /// \endif
        /// </summary>
        /// <param name="windowKey">
        /// \if KO
        /// <para>window Key에 사용할 <see cref="string"/> 값입니다.</para>
        /// \endif
        /// \if EN
        /// <para>The window key.</para>
        /// \endif
        /// </param>
        /// <returns>
        /// \if KO
        /// <para>Is Open 조건이 충족되면 <see langword="true"/>이고, 그렇지 않으면 <see langword="false"/>입니다.</para>
        /// \endif
        /// \if EN
        /// <para>True if the window is open; otherwise false.</para>
        /// \endif
        /// </returns>
        bool IsOpen(string windowKey);

        /// <summary>
        /// \if KO
        /// <para>Mark Opened 작업을 수행합니다.</para>
        /// \endif
        /// \if EN
        /// <para>Marks the window with the specified key as opened.</para>
        /// \endif
        /// </summary>
        /// <param name="windowKey">
        /// \if KO
        /// <para>window Key에 사용할 <see cref="string"/> 값입니다.</para>
        /// \endif
        /// \if EN
        /// <para>The window key.</para>
        /// \endif
        /// </param>
        void MarkOpened(string windowKey);

        /// <summary>
        /// \if KO
        /// <para>Mark Closed 작업을 수행합니다.</para>
        /// \endif
        /// \if EN
        /// <para>Marks the window with the specified key as closed.</para>
        /// \endif
        /// </summary>
        /// <param name="windowKey">
        /// \if KO
        /// <para>window Key에 사용할 <see cref="string"/> 값입니다.</para>
        /// \endif
        /// \if EN
        /// <para>The window key.</para>
        /// \endif
        /// </param>
        void MarkClosed(string windowKey);
    }
}