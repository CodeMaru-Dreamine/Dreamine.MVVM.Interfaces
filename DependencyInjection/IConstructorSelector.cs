using System;
using System.Reflection;

namespace Dreamine.MVVM.Interfaces.DependencyInjection
{
    /// <summary>
    /// \if KO
    /// <para>I Constructor Selector 기능과 관련 상태를 캡슐화합니다.</para>
    /// \endif
    /// \if EN
    /// <para>Selects a constructor for object activation.</para>
    /// \endif
    /// </summary>
    public interface IConstructorSelector
    {
        /// <summary>
        /// \if KO
        /// <para>Select Constructor 작업을 수행합니다.</para>
        /// \endif
        /// \if EN
        /// <para>Selects the constructor to use for the specified implementation type.</para>
        /// \endif
        /// </summary>
        /// <param name="implementationType">
        /// \if KO
        /// <para>implementation Type에 사용할 <see cref="Type"/> 값입니다.</para>
        /// \endif
        /// \if EN
        /// <para>The implementation type.</para>
        /// \endif
        /// </param>
        /// <returns>
        /// \if KO
        /// <para>Select Constructor 작업에서 생성한 <see cref="ConstructorInfo"/> 결과입니다.</para>
        /// \endif
        /// \if EN
        /// <para>The selected constructor.</para>
        /// \endif
        /// </returns>
        ConstructorInfo SelectConstructor(Type implementationType);
    }
}