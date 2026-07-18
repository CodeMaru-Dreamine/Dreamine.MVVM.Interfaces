using System;

namespace Dreamine.MVVM.Interfaces.DependencyInjection
{
    /// <summary>
    /// \if KO
    /// <para>I Auto Registration Filter 기능과 관련 상태를 캡슐화합니다.</para>
    /// \endif
    /// \if EN
    /// <para>Defines a rule that determines whether a type is eligible for automatic registration.</para>
    /// \endif
    /// </summary>
    public interface IAutoRegistrationFilter
    {
        /// <summary>
        /// \if KO
        /// <para>Is Target 조건을 확인합니다.</para>
        /// \endif
        /// \if EN
        /// <para>Determines whether the specified type is eligible for automatic registration.</para>
        /// \endif
        /// </summary>
        /// <param name="type">
        /// \if KO
        /// <para>type에 사용할 <see cref="Type"/> 값입니다.</para>
        /// \endif
        /// \if EN
        /// <para>The type to inspect.</para>
        /// \endif
        /// </param>
        /// <returns>
        /// \if KO
        /// <para>Is Target 조건이 충족되면 <see langword="true"/>이고, 그렇지 않으면 <see langword="false"/>입니다.</para>
        /// \endif
        /// \if EN
        /// <para>True if the type is eligible; otherwise false.</para>
        /// \endif
        /// </returns>
        bool IsTarget(Type type);
    }
}