using System;

namespace Dreamine.MVVM.Interfaces.DependencyInjection
{
    /// <summary>
    /// \if KO
    /// <para>I Service Resolver 기능과 관련 상태를 캡슐화합니다.</para>
    /// \endif
    /// \if EN
    /// <para>Provides service resolution capabilities.</para>
    /// \endif
    /// </summary>
    public interface IServiceResolver
    {
        /// <summary>
        /// \if KO
        /// <para>Resolve 작업을 수행합니다.</para>
        /// \endif
        /// \if EN
        /// <para>Resolves an instance of the specified service type.</para>
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
        /// <returns>
        /// \if KO
        /// <para>Resolve 작업에서 생성한 <typeparamref name="TService"/> 결과입니다.</para>
        /// \endif
        /// \if EN
        /// <para>The resolved service instance.</para>
        /// \endif
        /// </returns>
        TService Resolve<TService>()
            where TService : class;

        /// <summary>
        /// \if KO
        /// <para>Resolve 작업을 수행합니다.</para>
        /// \endif
        /// \if EN
        /// <para>Resolves an instance of the specified service type.</para>
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
        /// <para>Resolve 작업에서 생성한 <see cref="object"/> 결과입니다.</para>
        /// \endif
        /// \if EN
        /// <para>The resolved service instance.</para>
        /// \endif
        /// </returns>
        object Resolve(Type serviceType);

        /// <summary>
        /// \if KO
        /// <para>Resolve 작업을 시도하고 성공 여부를 반환합니다.</para>
        /// \endif
        /// \if EN
        /// <para>Attempts to resolve an instance of the specified service type without throwing.</para>
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
        /// <param name="result">
        /// \if KO
        /// <para>result에 사용할 <typeparamref name="TService"/> 값입니다.</para>
        /// \endif
        /// \if EN
        /// <para>The resolved instance, or <c>null</c> if not registered.</para>
        /// \endif
        /// </param>
        /// <returns>
        /// \if KO
        /// <para>Try Resolve 조건이 충족되면 <see langword="true"/>이고, 그렇지 않으면 <see langword="false"/>입니다.</para>
        /// \endif
        /// \if EN
        /// <para><c>true</c> if resolved successfully; otherwise <c>false</c>.</para>
        /// \endif
        /// </returns>
        bool TryResolve<TService>(out TService? result)
            where TService : class;
    }
}