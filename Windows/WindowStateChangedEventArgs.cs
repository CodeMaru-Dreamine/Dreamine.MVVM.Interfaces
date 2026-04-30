using System;

namespace Dreamine.MVVM.Interfaces.Windows
{
    /// <summary>
    /// Provides data for a window open-state changed event.
    /// </summary>
    public sealed class WindowStateChangedEventArgs : EventArgs
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WindowStateChangedEventArgs"/> class.
        /// </summary>
        /// <param name="windowKey">The window key.</param>
        /// <param name="isOpen">A value indicating whether the window is open.</param>
        public WindowStateChangedEventArgs(string windowKey, bool isOpen)
        {
            WindowKey = windowKey;
            IsOpen = isOpen;
        }

        /// <summary>
        /// Gets the window key.
        /// </summary>
        public string WindowKey { get; }

        /// <summary>
        /// Gets a value indicating whether the window is open.
        /// </summary>
        public bool IsOpen { get; }
    }
}