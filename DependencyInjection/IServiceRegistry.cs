using System;

namespace Dreamine.MVVM.Interfaces.DependencyInjection
{
    /// <summary>
    /// \if KO
    /// <para>I Service Registry 기능과 관련 상태를 캡슐화합니다.</para>
    /// \endif
    /// \if EN
    /// <para>Provides service registration capabilities.</para>
    /// \endif
    /// </summary>
    public interface IServiceRegistry
    {
        /// <summary>
        /// \if KO
        /// <para>Register 작업을 수행합니다.</para>
        /// \endif
        /// \if EN
        /// <para>Registers a concrete implementation type as itself with transient lifetime.</para>
        /// \endif
        /// </summary>
        /// <typeparam name="TImplementation">
        /// \if KO
        /// <para>TImplementation 형식 매개변수입니다.</para>
        /// \endif
        /// \if EN
        /// <para>The concrete implementation type.</para>
        /// \endif
        /// </typeparam>
        void Register<TImplementation>()
            where TImplementation : class;

        /// <summary>
        /// \if KO
        /// <para>Register 작업을 수행합니다.</para>
        /// \endif
        /// \if EN
        /// <para>Registers a service abstraction with a concrete implementation using transient lifetime.</para>
        /// \endif
        /// </summary>
        /// <typeparam name="TService">
        /// \if KO
        /// <para>TService 형식 매개변수입니다.</para>
        /// \endif
        /// \if EN
        /// <para>The service abstraction type.</para>
        /// \endif
        /// </typeparam>
        /// <typeparam name="TImplementation">
        /// \if KO
        /// <para>TImplementation 형식 매개변수입니다.</para>
        /// \endif
        /// \if EN
        /// <para>The concrete implementation type.</para>
        /// \endif
        /// </typeparam>
        void Register<TService, TImplementation>()
            where TService : class
            where TImplementation : class, TService;

        /// <summary>
        /// \if KO
        /// <para>Register 작업을 수행합니다.</para>
        /// \endif
        /// \if EN
        /// <para>Registers a factory for the specified service type using transient lifetime.</para>
        /// \endif
        /// </summary>
        /// <typeparam name="TService">
        /// \if KO
        /// <para>TService 형식 매개변수입니다.</para>
        /// \endif
        /// \if EN
        /// <para>The service type.</para>
        /// \endif
        /// </typeparam>
        /// <param name="factory">
        /// \if KO
        /// <para>factory에 사용할 <c>Func&lt;TService&gt;</c> 값입니다.</para>
        /// \endif
        /// \if EN
        /// <para>The factory used to create the service instance.</para>
        /// \endif
        /// </param>
        void Register<TService>(Func<TService> factory)
            where TService : class;

        /// <summary>
        /// \if KO
        /// <para>Register Singleton 작업을 수행합니다.</para>
        /// \endif
        /// \if EN
        /// <para>Registers a singleton instance for the specified service type.</para>
        /// \endif
        /// </summary>
        /// <typeparam name="TService">
        /// \if KO
        /// <para>TService 형식 매개변수입니다.</para>
        /// \endif
        /// \if EN
        /// <para>The service type.</para>
        /// \endif
        /// </typeparam>
        /// <param name="instance">
        /// \if KO
        /// <para>instance에 사용할 <typeparamref name="TService"/> 값입니다.</para>
        /// \endif
        /// \if EN
        /// <para>The singleton instance.</para>
        /// \endif
        /// </param>
        void RegisterSingleton<TService>(TService instance)
            where TService : class;

        /// <summary>
        /// \if KO
        /// <para>Register Singleton 작업을 수행합니다.</para>
        /// \endif
        /// \if EN
        /// <para>Registers a concrete implementation type as itself with singleton lifetime.</para>
        /// \endif
        /// </summary>
        /// <typeparam name="TImplementation">
        /// \if KO
        /// <para>TImplementation 형식 매개변수입니다.</para>
        /// \endif
        /// \if EN
        /// <para>The concrete implementation type.</para>
        /// \endif
        /// </typeparam>
        void RegisterSingleton<TImplementation>()
            where TImplementation : class;

        /// <summary>
        /// \if KO
        /// <para>Register Singleton 작업을 수행합니다.</para>
        /// \endif
        /// \if EN
        /// <para>Registers a service abstraction with a concrete implementation using singleton lifetime.</para>
        /// \endif
        /// </summary>
        /// <typeparam name="TService">
        /// \if KO
        /// <para>TService 형식 매개변수입니다.</para>
        /// \endif
        /// \if EN
        /// <para>The service abstraction type.</para>
        /// \endif
        /// </typeparam>
        /// <typeparam name="TImplementation">
        /// \if KO
        /// <para>TImplementation 형식 매개변수입니다.</para>
        /// \endif
        /// \if EN
        /// <para>The concrete implementation type.</para>
        /// \endif
        /// </typeparam>
        void RegisterSingleton<TService, TImplementation>()
            where TService : class
            where TImplementation : class, TService;

        /// <summary>
        /// \if KO
        /// <para>Is Registered 조건을 확인합니다.</para>
        /// \endif
        /// \if EN
        /// <para>Determines whether the specified service type is registered.</para>
        /// \endif
        /// </summary>
        /// <param name="serviceType">
        /// \if KO
        /// <para>service Type에 사용할 <see cref="Type"/> 값입니다.</para>
        /// \endif
        /// \if EN
        /// <para>The service type.</para>
        /// \endif
        /// </param>
        /// <returns>
        /// \if KO
        /// <para>Is Registered 조건이 충족되면 <see langword="true"/>이고, 그렇지 않으면 <see langword="false"/>입니다.</para>
        /// \endif
        /// \if EN
        /// <para>True if the service type is registered; otherwise false.</para>
        /// \endif
        /// </returns>
        bool IsRegistered(Type serviceType);
    }
}