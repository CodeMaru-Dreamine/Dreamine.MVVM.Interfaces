using System;

namespace Dreamine.MVVM.Interfaces.Windows
{
    /// <summary>
    /// Defines how a resolved view is displayed for a given view type.
    /// Register custom implementations via <c>ViewManager.RegisterDisplayStrategy</c>
    /// to support additional view types without modifying <c>ViewManager</c>.
    /// </summary>
    public interface IViewDisplayStrategy
    {
        /// <summary>
        /// Returns <c>true</c> when this strategy can handle the specified view instance.
        /// </summary>
        /// <param name="view">The resolved view object.</param>
        bool CanHandle(object view);

        /// <summary>
        /// Displays the view with the given ViewModel.
        /// </summary>
        /// <param name="view">The resolved view object.</param>
        /// <param name="viewModel">The resolved ViewModel object.</param>
        /// <param name="viewModelType">The ViewModel type (used for key resolution).</param>
        /// <param name="useRegionNavigator">
        /// <c>true</c> when display should delegate to <c>INavigator</c> if available.
        /// </param>
        void Display(object view, object viewModel, Type viewModelType, bool useRegionNavigator);
    }
}
