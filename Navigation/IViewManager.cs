using System;

namespace Dreamine.MVVM.Interfaces.Navigation
{
    /// <summary>
    /// Provides View display operations based on ViewModel types.
    /// </summary>
    public interface IViewManager
    {
        /// <summary>
        /// Shows the View that corresponds to the specified ViewModel type.
        /// </summary>
        /// <typeparam name="TViewModel">The ViewModel type used to resolve the target View.</typeparam>
        void Show<TViewModel>() where TViewModel : class;

        /// <summary>
        /// Shows the View that corresponds to the specified ViewModel type.
        /// </summary>
        /// <param name="viewModelType">The ViewModel type used to resolve the target View.</param>
        void Show(Type viewModelType);
    }
}