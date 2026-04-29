using System.Reflection;

namespace Dreamine.MVVM.Interfaces.DependencyInjection
{
    /// <summary>
    /// Provides automatic service registration features.
    /// </summary>
    public interface IAutoRegistrationService
    {
        /// <summary>
        /// Registers supported types from the specified root assembly.
        /// </summary>
        /// <param name="rootAssembly">The root assembly to scan first.</param>
        /// <param name="registry">The service registry to populate.</param>
        void RegisterAll(Assembly rootAssembly, IServiceRegistry registry);
    }
}