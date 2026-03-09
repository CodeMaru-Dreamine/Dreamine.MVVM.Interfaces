
# Dreamine.MVVM.Interfaces

Dreamine MVVM 프레임워크 전체에서 사용하는 **공통 인터페이스 계약(Interface Contracts)** 패키지입니다.

이 패키지는 Dreamine MVVM 생태계에서 필요한 최소한의 인터페이스들을 정의합니다.  
Locator, Navigation, Events, Behaviors 등의 모듈이 서로 직접 의존하지 않도록 설계되었습니다.

[➡️ English Version](./README.md)

---

## 목적

`Dreamine.MVVM.Interfaces`는 Dreamine MVVM 아키텍처에서 모듈 간 결합도를 낮추기 위한 공통 인터페이스를 제공합니다.

구현체에 직접 의존하는 대신 **인터페이스에 의존하도록 구조를 분리**합니다.

이를 통해 다음과 같은 효과를 얻을 수 있습니다.

- 모듈 간 낮은 결합도
- 명확한 아키텍처 경계
- 테스트 용이성
- 인프라 교체 가능성

---

## 주요 인터페이스

### IViewModelResolver

ViewModel 인스턴스를 생성하거나 가져오는 역할을 담당합니다.

사용 예시:

```csharp
var viewModel = resolver.Resolve(typeof(MainViewModel));
```

사용되는 영역:

- ViewModel Locator
- DI 컨테이너 연결
- Navigation 시스템

---

### INavigator

화면 이동을 위한 최소한의 네비게이션 계약 인터페이스입니다.

사용 예시:

```csharp
navigator.Navigate(viewModel);
```

역할:

- ViewModel → View 변환
- 화면 이동 처리
- UI 컨테이너 업데이트

대표 구현 예:

- ContentControlNavigator
- RegionNavigator

---

### IEventBase

이벤트 메시징 시스템을 위한 기본 인터페이스입니다.

모듈 간 직접 참조 없이 이벤트를 전달할 수 있도록 합니다.

사용 사례:

- 모듈 간 통신
- UI 이벤트 전달
- 백그라운드 작업 알림

---

## 이 패키지가 필요한 이유

대규모 MVVM 프로젝트는 모듈 간 의존성이 강해지면 구조가 무너지기 쉽습니다.

`Dreamine.MVVM.Interfaces`는 **공통 인터페이스만 제공하는 레이어**를 만들어 이 문제를 해결합니다.

아키텍처 원칙:

```
상위 모듈은 구현이 아니라 추상화에 의존한다.
```

이는 **SOLID 원칙 중 Dependency Inversion Principle**을 따르는 구조입니다.

---

## Dreamine MVVM 구조 내 위치

```
Dreamine.MVVM.Interfaces
        ↑
Dreamine.MVVM.Locators
Dreamine.MVVM.Navigation
Dreamine.MVVM.Events
Dreamine.MVVM.Behaviors
```

상위 레이어 모듈들은 모두 이 인터페이스 패키지를 기반으로 동작합니다.

---

## 설치

```bash
dotnet add package Dreamine.MVVM.Interfaces
```

또는 프로젝트 파일에 직접 추가합니다.

```xml
<PackageReference Include="Dreamine.MVVM.Interfaces" Version="1.0.0" />
```

---

## 요구 사항

- .NET 8.0
- UI 의존성 없음

---

## License

MIT License
