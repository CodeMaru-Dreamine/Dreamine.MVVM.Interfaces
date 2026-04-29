namespace Dreamine.MVVM.Interfaces.DependencyInjection
{
    /// <summary>
    /// Represents a service container that supports both registration and resolution.
    /// </summary>
    public interface IServiceContainer : IServiceRegistry, IServiceResolver
    {
    }
}