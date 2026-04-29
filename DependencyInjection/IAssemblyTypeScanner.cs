using System;
using System.Collections.Generic;
using System.Reflection;

namespace Dreamine.MVVM.Interfaces.DependencyInjection
{
    /// <summary>
    /// Scans assemblies and returns loadable concrete types.
    /// </summary>
    public interface IAssemblyTypeScanner
    {
        /// <summary>
        /// Gets candidate assemblies for auto registration.
        /// </summary>
        /// <param name="rootAssembly">The root assembly to prioritize.</param>
        /// <returns>The candidate assemblies.</returns>
        IEnumerable<Assembly> GetCandidateAssemblies(Assembly rootAssembly);

        /// <summary>
        /// Gets loadable types from the specified assembly.
        /// </summary>
        /// <param name="assembly">The assembly to scan.</param>
        /// <returns>The loadable types.</returns>
        IEnumerable<Type> GetLoadableTypes(Assembly assembly);
    }
}