using System;

namespace Dreamine.MVVM.Interfaces.DependencyInjection
{
    /// <summary>
    /// Provides service registration capabilities.
    /// </summary>
    public interface IServiceRegistry
    {
        /// <summary>
        /// Registers a concrete implementation type as itself with transient lifetime.
        /// </summary>
        /// <typeparam name="TImplementation">The concrete implementation type.</typeparam>
        void Register<TImplementation>()
            where TImplementation : class;

        /// <summary>
        /// Registers a service abstraction with a concrete implementation using transient lifetime.
        /// </summary>
        /// <typeparam name="TService">The service abstraction type.</typeparam>
        /// <typeparam name="TImplementation">The concrete implementation type.</typeparam>
        void Register<TService, TImplementation>()
            where TService : class
            where TImplementation : class, TService;

        /// <summary>
        /// Registers a factory for the specified service type using transient lifetime.
        /// </summary>
        /// <typeparam name="TService">The service type.</typeparam>
        /// <param name="factory">The factory used to create the service instance.</param>
        void Register<TService>(Func<TService> factory)
            where TService : class;

        /// <summary>
        /// Registers a singleton instance for the specified service type.
        /// </summary>
        /// <typeparam name="TService">The service type.</typeparam>
        /// <param name="instance">The singleton instance.</param>
        void RegisterSingleton<TService>(TService instance)
            where TService : class;

        /// <summary>
        /// Registers a concrete implementation type as itself with singleton lifetime.
        /// </summary>
        /// <typeparam name="TImplementation">The concrete implementation type.</typeparam>
        void RegisterSingleton<TImplementation>()
            where TImplementation : class;

        /// <summary>
        /// Registers a service abstraction with a concrete implementation using singleton lifetime.
        /// </summary>
        /// <typeparam name="TService">The service abstraction type.</typeparam>
        /// <typeparam name="TImplementation">The concrete implementation type.</typeparam>
        void RegisterSingleton<TService, TImplementation>()
            where TService : class
            where TImplementation : class, TService;

        /// <summary>
        /// Determines whether the specified service type is registered.
        /// </summary>
        /// <param name="serviceType">The service type.</param>
        /// <returns>True if the service type is registered; otherwise false.</returns>
        bool IsRegistered(Type serviceType);
    }
}