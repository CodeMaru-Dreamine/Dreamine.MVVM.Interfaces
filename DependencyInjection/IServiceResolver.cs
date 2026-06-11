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

        /// <summary>
        /// Attempts to resolve an instance of the specified service type without throwing.
        /// </summary>
        /// <typeparam name="TService">The service type.</typeparam>
        /// <param name="result">The resolved instance, or <c>null</c> if not registered.</param>
        /// <returns><c>true</c> if resolved successfully; otherwise <c>false</c>.</returns>
        bool TryResolve<TService>(out TService? result)
            where TService : class;
    }
}