using System;

namespace Dreamine.MVVM.Interfaces.DependencyInjection
{
    /// <summary>
    /// Defines a rule that determines whether a type is eligible for automatic registration.
    /// </summary>
    public interface IAutoRegistrationFilter
    {
        /// <summary>
        /// Determines whether the specified type is eligible for automatic registration.
        /// </summary>
        /// <param name="type">The type to inspect.</param>
        /// <returns>True if the type is eligible; otherwise false.</returns>
        bool IsTarget(Type type);
    }
}