using System;

namespace Dreamine.MVVM.Interfaces.Windows
{
    /// <summary>
    /// \if KO
    /// <para>I View Display Strategy 기능과 관련 상태를 캡슐화합니다.</para>
    /// \endif
    /// \if EN
    /// <para>Defines how a resolved view is displayed for a given view type. Register custom implementations via <c>ViewManager.RegisterDisplayStrategy</c> to support additional view types without modifying <c>ViewManager</c>.</para>
    /// \endif
    /// </summary>
    public interface IViewDisplayStrategy
    {
        /// <summary>
        /// \if KO
        /// <para>Can Handle 조건을 확인합니다.</para>
        /// \endif
        /// \if EN
        /// <para>Returns <c>true</c> when this strategy can handle the specified view instance.</para>
        /// \endif
        /// </summary>
        /// <param name="view">
        /// \if KO
        /// <para>view에 사용할 <see cref="object"/> 값입니다.</para>
        /// \endif
        /// \if EN
        /// <para>The resolved view object.</para>
        /// \endif
        /// </param>
        /// <returns>
        /// \if KO
        /// <para>Can Handle 조건이 충족되면 <see langword="true"/>이고, 그렇지 않으면 <see langword="false"/>입니다.</para>
        /// \endif
        /// \if EN
        /// <para><see langword="true"/> when the can handle condition is satisfied; otherwise, <see langword="false"/>.</para>
        /// \endif
        /// </returns>
        bool CanHandle(object view);

        /// <summary>
        /// \if KO
        /// <para>Display 작업을 수행합니다.</para>
        /// \endif
        /// \if EN
        /// <para>Displays the view with the given ViewModel.</para>
        /// \endif
        /// </summary>
        /// <param name="view">
        /// \if KO
        /// <para>view에 사용할 <see cref="object"/> 값입니다.</para>
        /// \endif
        /// \if EN
        /// <para>The resolved view object.</para>
        /// \endif
        /// </param>
        /// <param name="viewModel">
        /// \if KO
        /// <para>view Model에 사용할 <see cref="object"/> 값입니다.</para>
        /// \endif
        /// \if EN
        /// <para>The resolved ViewModel object.</para>
        /// \endif
        /// </param>
        /// <param name="viewModelType">
        /// \if KO
        /// <para>view Model Type에 사용할 <see cref="Type"/> 값입니다.</para>
        /// \endif
        /// \if EN
        /// <para>The ViewModel type (used for key resolution).</para>
        /// \endif
        /// </param>
        /// <param name="useRegionNavigator">
        /// \if KO
        /// <para>use Region Navigator에 사용할 <see cref="bool"/> 값입니다.</para>
        /// \endif
        /// \if EN
        /// <para><c>true</c> when display should delegate to <c>INavigator</c> if available.</para>
        /// \endif
        /// </param>
        void Display(object view, object viewModel, Type viewModelType, bool useRegionNavigator);
    }
}
