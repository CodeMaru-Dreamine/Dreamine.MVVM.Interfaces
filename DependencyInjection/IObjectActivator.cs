using System;

namespace Dreamine.MVVM.Interfaces.DependencyInjection
{
    /// <summary>
    /// Creates object instances using constructor injection.
    /// </summary>
    public interface IObjectActivator
    {
        /// <summary>
        /// Creates an instance of the specified implementation type.
        /// </summary>
        /// <param name="implementationType">The implementation type.</param>
        /// <param name="resolver">The resolver used to resolve constructor dependencies.</param>
        /// <returns>The created object instance.</returns>
        object CreateInstance(Type implementationType, IServiceResolver resolver);
    }
}