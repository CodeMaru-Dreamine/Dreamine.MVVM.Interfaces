using Dreamine.MVVM.Interfaces.DependencyInjection;
using Dreamine.MVVM.Interfaces.Navigation;
using Dreamine.MVVM.Interfaces.Windows;
using System.Reflection;
using Xunit;

namespace Dreamine.MVVM.Interfaces.Tests;

public sealed class ContractTests
{
    [Theory]
    [InlineData("main", true)]
    [InlineData("settings", false)]
    public void WindowStateChangedEventArgs_PreservesEventPayload(string key, bool isOpen)
    {
        var args = new WindowStateChangedEventArgs(key, isOpen);

        Assert.Equal(key, args.WindowKey);
        Assert.Equal(isOpen, args.IsOpen);
        Assert.IsAssignableFrom<EventArgs>(args);
        Assert.IsAssignableFrom<IWindowStateChange>(args);
    }

    [Fact]
    public void ServiceContainer_ComposesRegistrationAndResolutionContracts()
    {
        Assert.True(typeof(IServiceRegistry).IsAssignableFrom(typeof(IServiceContainer)));
        Assert.True(typeof(IServiceResolver).IsAssignableFrom(typeof(IServiceContainer)));
    }

    [Fact]
    public void ViewManager_ExtendsNavigatorWithoutUiFrameworkDependency()
    {
        Assert.True(typeof(INavigator).IsAssignableFrom(typeof(IViewManager)));
        Assert.DoesNotContain(
            typeof(IViewManager).Assembly.GetReferencedAssemblies(),
            assembly => assembly.Name is "PresentationFramework" or "WindowsBase");
    }

    [Fact]
    public void PublicContracts_RemainInterfacesExceptForEventPayload()
    {
        var publicTypes = typeof(IServiceResolver).Assembly
            .GetExportedTypes()
            .OrderBy(type => type.FullName)
            .ToArray();

        Assert.NotEmpty(publicTypes);
        Assert.All(
            publicTypes.Where(type => type != typeof(WindowStateChangedEventArgs)),
            type => Assert.True(type.IsInterface, $"{type.FullName} must remain an interface."));
        Assert.True(typeof(WindowStateChangedEventArgs).IsSealed);
    }

    [Fact]
    public void DialogContract_ExposesSynchronousAndAsynchronousOperations()
    {
        var methods = typeof(IDialogService).GetMethods(BindingFlags.Public | BindingFlags.Instance);

        Assert.Contains(methods, method => method.Name == nameof(IDialogService.ShowMessage));
        Assert.Contains(methods, method => method.Name == nameof(IDialogService.ShowMessageAsync));
        Assert.Contains(methods, method => method.Name == nameof(IDialogService.Confirm));
        Assert.Contains(methods, method => method.Name == nameof(IDialogService.ConfirmAsync));
    }
}
