using System;

namespace Dreamine.MVVM.Interfaces.DependencyInjection
{
    /// <summary>
    /// \if KO
    /// <para>I Object Activator 기능과 관련 상태를 캡슐화합니다.</para>
    /// \endif
    /// \if EN
    /// <para>Creates object instances using constructor injection.</para>
    /// \endif
    /// </summary>
    public interface IObjectActivator
    {
        /// <summary>
        /// \if KO
        /// <para>Instance 값을 생성합니다.</para>
        /// \endif
        /// \if EN
        /// <para>Creates an instance of the specified implementation type.</para>
        /// \endif
        /// </summary>
        /// <param name="implementationType">
        /// \if KO
        /// <para>implementation Type에 사용할 <see cref="Type"/> 값입니다.</para>
        /// \endif
        /// \if EN
        /// <para>The implementation type.</para>
        /// \endif
        /// </param>
        /// <param name="resolver">
        /// \if KO
        /// <para>resolver에 사용할 <see cref="IServiceResolver"/> 값입니다.</para>
        /// \endif
        /// \if EN
        /// <para>The resolver used to resolve constructor dependencies.</para>
        /// \endif
        /// </param>
        /// <returns>
        /// \if KO
        /// <para>Create Instance 작업에서 생성한 <see cref="object"/> 결과입니다.</para>
        /// \endif
        /// \if EN
        /// <para>The created object instance.</para>
        /// \endif
        /// </returns>
        object CreateInstance(Type implementationType, IServiceResolver resolver);
    }
}