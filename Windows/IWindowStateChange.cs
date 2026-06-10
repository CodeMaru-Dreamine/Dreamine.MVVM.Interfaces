namespace Dreamine.MVVM.Interfaces.Windows
{
    /// <summary>
    /// Describes a window open-state change without requiring consumers to depend on a concrete event args type.
    /// </summary>
    public interface IWindowStateChange
    {
        /// <summary>
        /// Gets the window key.
        /// </summary>
        string WindowKey { get; }

        /// <summary>
        /// Gets a value indicating whether the window is open.
        /// </summary>
        bool IsOpen { get; }
    }
}
