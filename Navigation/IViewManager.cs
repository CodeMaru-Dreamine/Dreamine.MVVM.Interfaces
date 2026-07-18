using System;

namespace Dreamine.MVVM.Interfaces.Navigation
{
    /// <summary>
    /// \if KO
    /// <para>I View Manager 기능과 관련 상태를 캡슐화합니다.</para>
    /// \endif
    /// \if EN
    /// <para>Provides View display operations based on ViewModel instances or ViewModel types.</para>
    /// \endif
    /// </summary>
    /// <remarks>
    /// \if KO
    /// <para>이 멤버의 동작과 사용 시 고려 사항을 설명합니다.</para>
    /// \endif
    /// \if EN
    /// <para>This is the application-level View display contract. It extends <see cref="INavigator"/> so instance-based and type-based display operations stay in one navigation contract family.</para>
    /// \endif
    /// </remarks>
    public interface IViewManager : INavigator
    {
        /// <summary>
        /// \if KO
        /// <para>Show 작업을 수행합니다.</para>
        /// \endif
        /// \if EN
        /// <para>Shows the View that corresponds to the specified ViewModel type.</para>
        /// \endif
        /// </summary>
        /// <typeparam name="TViewModel">
        /// \if KO
        /// <para>TViewModel 형식 매개변수입니다.</para>
        /// \endif
        /// \if EN
        /// <para>The ViewModel type used to resolve the target View.</para>
        /// \endif
        /// </typeparam>
        void Show<TViewModel>() where TViewModel : class;

        /// <summary>
        /// \if KO
        /// <para>Show 작업을 수행합니다.</para>
        /// \endif
        /// \if EN
        /// <para>Shows the View that corresponds to the specified ViewModel type.</para>
        /// \endif
        /// </summary>
        /// <param name="viewModelType">
        /// \if KO
        /// <para>view Model Type에 사용할 <see cref="Type"/> 값입니다.</para>
        /// \endif
        /// \if EN
        /// <para>The ViewModel type used to resolve the target View.</para>
        /// \endif
        /// </param>
        void Show(Type viewModelType);
    }
}
