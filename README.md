
# Dreamine.MVVM.Interfaces

Core interface contracts used across the Dreamine MVVM framework.

This package defines the minimal set of abstractions required by the Dreamine MVVM ecosystem.  
It allows different modules (Locators, Behaviors, Navigation, Events, etc.) to interact without direct dependencies.

[➡️ 한국어 문서 보기](./README_ko.md)

---

## Purpose

`Dreamine.MVVM.Interfaces` provides shared contracts that enable loose coupling between the modules of the Dreamine MVVM architecture.

Instead of referencing concrete implementations, higher-level components depend only on these interfaces.

This ensures:

- low coupling
- clear architectural boundaries
- easier testing
- replaceable infrastructure components

---

## Main Interfaces

### IViewModelResolver

Responsible for resolving ViewModel instances.

Typical usage:

```csharp
var viewModel = resolver.Resolve(typeof(MainViewModel));
```

Used by:

- ViewModel Locator
- Dependency Injection bridges
- Navigation systems

---

### INavigator

Defines a minimal navigation contract.

Typical usage:

```csharp
navigator.Navigate(viewModel);
```

Responsibilities:

- View resolution from ViewModel
- navigation between views
- UI container updates

Common implementations:

- ContentControlNavigator
- RegionNavigator

---

### IEventBase

Base abstraction for event messaging systems.

Allows modules to publish or subscribe to application events without tight coupling.

Typical scenarios:

- cross-module communication
- UI event broadcasting
- background task notifications

---

## Why This Package Exists

Large MVVM systems often fail because modules depend directly on each other.

This package solves that problem by introducing **shared contracts only**.

Architecture principle:

```
High-level modules depend on abstractions.
Low-level modules implement those abstractions.
```

This follows the **Dependency Inversion Principle (SOLID)**.

---

## Package Role in Dreamine MVVM

```
Dreamine.MVVM.Interfaces
        ↑
Dreamine.MVVM.Locators
Dreamine.MVVM.Navigation
Dreamine.MVVM.Events
Dreamine.MVVM.Behaviors
```

All higher-level packages rely on these interfaces.

---

## Installation

```bash
dotnet add package Dreamine.MVVM.Interfaces
```

Or add to your project file:

```xml
<PackageReference Include="Dreamine.MVVM.Interfaces" Version="1.0.0" />
```

---

## Requirements

- .NET 8.0
- No UI dependencies

---

## License

MIT License
