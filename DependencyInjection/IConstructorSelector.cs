using System;
using System.Reflection;

namespace Dreamine.MVVM.Interfaces.DependencyInjection
{
    /// <summary>
    /// Selects a constructor for object activation.
    /// </summary>
    public interface IConstructorSelector
    {
        /// <summary>
        /// Selects the constructor to use for the specified implementation type.
        /// </summary>
        /// <param name="implementationType">The implementation type.</param>
        /// <returns>The selected constructor.</returns>
        ConstructorInfo SelectConstructor(Type implementationType);
    }
}