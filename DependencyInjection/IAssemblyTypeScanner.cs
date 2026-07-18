using System;
using System.Collections.Generic;
using System.Reflection;

namespace Dreamine.MVVM.Interfaces.DependencyInjection
{
    /// <summary>
    /// \if KO
    /// <para>I Assembly Type Scanner 기능과 관련 상태를 캡슐화합니다.</para>
    /// \endif
    /// \if EN
    /// <para>Scans assemblies and returns loadable concrete types.</para>
    /// \endif
    /// </summary>
    public interface IAssemblyTypeScanner
    {
        /// <summary>
        /// \if KO
        /// <para>Candidate Assemblies 값을 가져옵니다.</para>
        /// \endif
        /// \if EN
        /// <para>Gets candidate assemblies for auto registration.</para>
        /// \endif
        /// </summary>
        /// <param name="rootAssembly">
        /// \if KO
        /// <para>root Assembly에 사용할 <see cref="Assembly"/> 값입니다.</para>
        /// \endif
        /// \if EN
        /// <para>The root assembly to prioritize.</para>
        /// \endif
        /// </param>
        /// <returns>
        /// \if KO
        /// <para>Get Candidate Assemblies 작업에서 생성한 <see cref="IEnumerable{Assembly}"/> 결과입니다.</para>
        /// \endif
        /// \if EN
        /// <para>The candidate assemblies.</para>
        /// \endif
        /// </returns>
        IEnumerable<Assembly> GetCandidateAssemblies(Assembly rootAssembly);

        /// <summary>
        /// \if KO
        /// <para>Loadable Types 값을 가져옵니다.</para>
        /// \endif
        /// \if EN
        /// <para>Gets loadable types from the specified assembly.</para>
        /// \endif
        /// </summary>
        /// <param name="assembly">
        /// \if KO
        /// <para>assembly에 사용할 <see cref="Assembly"/> 값입니다.</para>
        /// \endif
        /// \if EN
        /// <para>The assembly to scan.</para>
        /// \endif
        /// </param>
        /// <returns>
        /// \if KO
        /// <para>Get Loadable Types 작업에서 생성한 <see cref="IEnumerable{Type}"/> 결과입니다.</para>
        /// \endif
        /// \if EN
        /// <para>The loadable types.</para>
        /// \endif
        /// </returns>
        IEnumerable<Type> GetLoadableTypes(Assembly assembly);
    }
}