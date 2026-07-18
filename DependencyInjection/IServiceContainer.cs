namespace Dreamine.MVVM.Interfaces.DependencyInjection
{
    /// <summary>
    /// \if KO
    /// <para>I Service Container 기능과 관련 상태를 캡슐화합니다.</para>
    /// \endif
    /// \if EN
    /// <para>Represents a service container that supports both registration and resolution.</para>
    /// \endif
    /// </summary>
    public interface IServiceContainer : IServiceRegistry, IServiceResolver
    {
    }
}