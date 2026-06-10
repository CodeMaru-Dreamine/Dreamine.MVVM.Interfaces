namespace Dreamine.MVVM.Interfaces.Navigation
{
    /// <summary>
    /// Provides instance-based navigation for an already created ViewModel.
    /// </summary>
    /// <remarks>
    /// This is the smallest navigation contract and is usually implemented by region-based presenters.
    /// Use <see cref="IViewManager"/> when a component also needs type-based ViewModel resolution.
    /// </remarks>
    public interface INavigator
    {
        /// <summary>
        /// Navigates to the View that corresponds to the specified ViewModel instance.
        /// </summary>
        /// <param name="viewModel">The ViewModel instance to display.</param>
        void Navigate(object viewModel);
    }
}
