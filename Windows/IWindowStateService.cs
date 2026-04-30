using System;

namespace Dreamine.MVVM.Interfaces.Windows
{
    /// <summary>
    /// Provides window open-state tracking.
    /// </summary>
    public interface IWindowStateService
    {
        /// <summary>
        /// Occurs when a window open-state changes.
        /// </summary>
        event EventHandler<WindowStateChangedEventArgs>? StateChanged;

        /// <summary>
        /// Determines whether the window with the specified key is open.
        /// </summary>
        /// <param name="windowKey">The window key.</param>
        /// <returns>True if the window is open; otherwise false.</returns>
        bool IsOpen(string windowKey);

        /// <summary>
        /// Marks the window with the specified key as opened.
        /// </summary>
        /// <param name="windowKey">The window key.</param>
        void MarkOpened(string windowKey);

        /// <summary>
        /// Marks the window with the specified key as closed.
        /// </summary>
        /// <param name="windowKey">The window key.</param>
        void MarkClosed(string windowKey);
    }
}