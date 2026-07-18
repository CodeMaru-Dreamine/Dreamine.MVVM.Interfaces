namespace Dreamine.MVVM.Interfaces.Events
{
    /// <summary>
    /// \if KO
    /// <para>I Event Base 기능과 관련 상태를 캡슐화합니다.</para>
    /// \endif
    /// \if EN
    /// <para>Marks a type as an explicit Dreamine event contract.</para>
    /// \endif
    /// </summary>
    /// <remarks>
    /// \if KO
    /// <para>이 멤버의 동작과 사용 시 고려 사항을 설명합니다.</para>
    /// \endif
    /// \if EN
    /// <para>This marker is not intended to be a broad source-generation trigger by itself. Generators and scanners should combine it with explicit Dreamine attributes, naming rules, or namespace rules before treating a type as an automatic target.</para>
    /// \endif
    /// </remarks>
    public interface IEventBase
    {
    }
}
