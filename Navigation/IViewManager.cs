using System;

namespace Dreamine.MVVM.Interfaces.Navigation
{
    /// <summary>
    /// Provides View display operations based on ViewModel instances or ViewModel types.
    /// </summary>
    /// <remarks>
    /// This is the application-level View display contract. It extends <see cref="INavigator"/>
    /// so instance-based and type-based display operations stay in one navigation contract family.
    /// </remarks>
    public interface IViewManager : INavigator
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
