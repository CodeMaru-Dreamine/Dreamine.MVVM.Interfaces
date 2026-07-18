namespace Dreamine.MVVM.Interfaces.Navigation
{
    /// <summary>
    /// \if KO
    /// <para>I Navigator 기능과 관련 상태를 캡슐화합니다.</para>
    /// \endif
    /// \if EN
    /// <para>Provides instance-based navigation for an already created ViewModel.</para>
    /// \endif
    /// </summary>
    /// <remarks>
    /// \if KO
    /// <para>이 멤버의 동작과 사용 시 고려 사항을 설명합니다.</para>
    /// \endif
    /// \if EN
    /// <para>This is the smallest navigation contract and is usually implemented by region-based presenters. Use <see cref="IViewManager"/> when a component also needs type-based ViewModel resolution.</para>
    /// \endif
    /// </remarks>
    public interface INavigator
    {
        /// <summary>
        /// \if KO
        /// <para>Navigate 작업을 수행합니다.</para>
        /// \endif
        /// \if EN
        /// <para>Navigates to the View that corresponds to the specified ViewModel instance.</para>
        /// \endif
        /// </summary>
        /// <param name="viewModel">
        /// \if KO
        /// <para>view Model에 사용할 <see cref="object"/> 값입니다.</para>
        /// \endif
        /// \if EN
        /// <para>The ViewModel instance to display.</para>
        /// \endif
        /// </param>
        void Navigate(object viewModel);
    }
}
