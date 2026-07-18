namespace Dreamine.MVVM.Interfaces;

/// <summary>
/// \if KO
/// <para>I Visibility Aware 기능과 관련 상태를 캡슐화합니다.</para>
/// \endif
/// \if EN
/// <para>Encapsulates i visibility aware functionality and related state.</para>
/// \endif
/// </summary>
public interface IVisibilityAware
{
    /// <summary>
    /// \if KO
    /// <para>Shown 이벤트 또는 상태 변경을 처리합니다.</para>
    /// \endif
    /// \if EN
    /// <para>Handles the shown event or state change.</para>
    /// \endif
    /// </summary>
    void OnShown();
    /// <summary>
    /// \if KO
    /// <para>Hidden 이벤트 또는 상태 변경을 처리합니다.</para>
    /// \endif
    /// \if EN
    /// <para>Handles the hidden event or state change.</para>
    /// \endif
    /// </summary>
    void OnHidden();
}
