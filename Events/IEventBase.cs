namespace Dreamine.MVVM.Interfaces.Events
{
    /// <summary>
    /// Marks a type as an explicit Dreamine event contract.
    /// </summary>
    /// <remarks>
    /// This marker is not intended to be a broad source-generation trigger by itself.
    /// Generators and scanners should combine it with explicit Dreamine attributes,
    /// naming rules, or namespace rules before treating a type as an automatic target.
    /// </remarks>
    public interface IEventBase
    {
    }
}
