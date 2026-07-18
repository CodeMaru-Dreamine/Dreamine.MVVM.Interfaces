using System;

namespace Dreamine.MVVM.Interfaces.Windows
{
    /// <summary>
    /// \if KO
    /// <para>Window State Changed Event Args 기능과 관련 상태를 캡슐화합니다.</para>
    /// \endif
    /// \if EN
    /// <para>Provides data for a window open-state changed event.</para>
    /// \endif
    /// </summary>
    public sealed class WindowStateChangedEventArgs : EventArgs, IWindowStateChange
    {
        /// <summary>
        /// \if KO
        /// <para>지정한 설정으로 <see cref="WindowStateChangedEventArgs"/> 클래스의 새 인스턴스를 초기화합니다.</para>
        /// \endif
        /// \if EN
        /// <para>Initializes a new instance of the <see cref="WindowStateChangedEventArgs"/> class.</para>
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
        /// <param name="isOpen">
        /// \if KO
        /// <para>is Open에 사용할 <see cref="bool"/> 값입니다.</para>
        /// \endif
        /// \if EN
        /// <para>A value indicating whether the window is open.</para>
        /// \endif
        /// </param>
        public WindowStateChangedEventArgs(string windowKey, bool isOpen)
        {
            WindowKey = windowKey;
            IsOpen = isOpen;
        }

        /// <summary>
        /// \if KO
        /// <para>Window Key 값을 가져옵니다.</para>
        /// \endif
        /// \if EN
        /// <para>Gets the window key.</para>
        /// \endif
        /// </summary>
        public string WindowKey { get; }

        /// <summary>
        /// \if KO
        /// <para>Is Open 값을 가져옵니다.</para>
        /// \endif
        /// \if EN
        /// <para>Gets a value indicating whether the window is open.</para>
        /// \endif
        /// </summary>
        public bool IsOpen { get; }
    }
}
