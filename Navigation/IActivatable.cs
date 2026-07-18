namespace Dreamine.MVVM.Interfaces;

/// <summary>
/// \if KO
/// <para>I Activatable 기능과 관련 상태를 캡슐화합니다.</para>
/// \endif
/// \if EN
/// <para>Encapsulates i activatable functionality and related state.</para>
/// \endif
/// </summary>
public interface IActivatable
{
    /// <summary>
    /// \if KO
    /// <para>Activate 작업을 수행합니다.</para>
    /// \endif
    /// \if EN
    /// <para>Performs the activate operation.</para>
    /// \endif
    /// </summary>
    void Activate();
    /// <summary>
    /// \if KO
    /// <para>Deactivate 작업을 수행합니다.</para>
    /// \endif
    /// \if EN
    /// <para>Performs the deactivate operation.</para>
    /// \endif
    /// </summary>
    void Deactivate();
}
