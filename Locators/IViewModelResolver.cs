
namespace Dreamine.MVVM.Interfaces.Locators
{
	/// <summary>
	/// \if KO
	/// <para>📌 ViewModel 생성 전략을 위한 DI 추상 인터페이스입니다. Dreamine의 ViewModelLocator와 함께 사용되며, DI 컨테이너 또는 수동 인스턴스화 전략을 연결하는 역할을 합니다.</para>
	/// \endif
	/// \if EN
	/// <para>Encapsulates i view model resolver functionality and related state.</para>
	/// \endif
	/// </summary>
	public interface IViewModelResolver
	{
		/// <summary>
		/// \if KO
		/// <para>지정된 ViewModel 타입을 생성하여 반환합니다.</para>
		/// \endif
		/// \if EN
		/// <para>Performs the resolve operation.</para>
		/// \endif
		/// </summary>
		/// <param name="viewModelType">
		/// \if KO
		/// <para>생성할 ViewModel의 Type 정보</para>
		/// \endif
		/// \if EN
		/// <para>The <see cref="Type"/> value used for view model type.</para>
		/// \endif
		/// </param>
		/// <returns>
		/// \if KO
		/// <para>ViewModel 인스턴스 또는 null</para>
		/// \endif
		/// \if EN
		/// <para>The <see cref="object"/> result produced by the resolve operation.</para>
		/// \endif
		/// </returns>
		object? Resolve(Type viewModelType);
	}
}
