using System.Reflection;

namespace Dreamine.MVVM.Interfaces.DependencyInjection
{
    /// <summary>
    /// \if KO
    /// <para>I Auto Registration Service 기능과 관련 상태를 캡슐화합니다.</para>
    /// \endif
    /// \if EN
    /// <para>Provides automatic service registration features.</para>
    /// \endif
    /// </summary>
    public interface IAutoRegistrationService
    {
        /// <summary>
        /// \if KO
        /// <para>Register All 작업을 수행합니다.</para>
        /// \endif
        /// \if EN
        /// <para>Registers supported types from the specified root assembly.</para>
        /// \endif
        /// </summary>
        /// <param name="rootAssembly">
        /// \if KO
        /// <para>root Assembly에 사용할 <see cref="Assembly"/> 값입니다.</para>
        /// \endif
        /// \if EN
        /// <para>The root assembly to scan first.</para>
        /// \endif
        /// </param>
        /// <param name="registry">
        /// \if KO
        /// <para>registry에 사용할 <see cref="IServiceRegistry"/> 값입니다.</para>
        /// \endif
        /// \if EN
        /// <para>The service registry to populate.</para>
        /// \endif
        /// </param>
        void RegisterAll(Assembly rootAssembly, IServiceRegistry registry);
    }
}