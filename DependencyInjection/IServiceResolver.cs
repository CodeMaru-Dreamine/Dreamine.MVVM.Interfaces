using System;

namespace Dreamine.MVVM.Interfaces.DependencyInjection
{
    /// <summary>
    /// Provides service resolution capabilities.
    /// </summary>
    public interface IServiceResolver
    {
        /// <summary>
        /// Resolves an instance of the specified service type.
        /// </summary>
        /// <typeparam name="TService">The service type.</typeparam>
        /// <returns>The resolved service instance.</returns>
        TService Resolve<TService>()
            where TService : class;

        /// <summary>
        /// Resolves an instance of the specified service type.
        /// </summary>
        /// <param name="serviceType">The service type.</param>
        /// <returns>The resolved service instance.</returns>
        object Resolve(Type serviceType);
    }
}