namespace Dreamine.MVVM.Interfaces.Windows
{
    /// <summary>
    /// \if KO
    /// <para>I Window State Change 기능과 관련 상태를 캡슐화합니다.</para>
    /// \endif
    /// \if EN
    /// <para>Describes a window open-state change without requiring consumers to depend on a concrete event args type.</para>
    /// \endif
    /// </summary>
    public interface IWindowStateChange
    {
        /// <summary>
        /// \if KO
        /// <para>Window Key 값을 가져옵니다.</para>
        /// \endif
        /// \if EN
        /// <para>Gets the window key.</para>
        /// \endif
        /// </summary>
        string WindowKey { get; }

        /// <summary>
        /// \if KO
        /// <para>Is Open 값을 가져옵니다.</para>
        /// \endif
        /// \if EN
        /// <para>Gets a value indicating whether the window is open.</para>
        /// \endif
        /// </summary>
        bool IsOpen { get; }
    }
}
