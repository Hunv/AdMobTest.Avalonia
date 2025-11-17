using Avalonia;
using Avalonia.iOS;
using Avalonia.ReactiveUI;

using Foundation;
using Jc.AdMob.Avalonia;
using Jc.AdMob.Avalonia.iOS;

namespace AdMobTest.iOS;

// The UIApplicationDelegate for the application. This class is responsible for launching the 
// User Interface of the application, as well as listening (and optionally responding) to 
// application events from iOS.
[Register("AppDelegate")]
public partial class AppDelegate : AvaloniaAppDelegate<App>
{
    protected override AppBuilder CustomizeAppBuilder(AppBuilder builder)
    {
        return base.CustomizeAppBuilder(builder)
            .WithInterFont()
            .UseReactiveUI()
            .UseAdMob(new AdMobOptions
            {
                TestDeviceIds = [],
                TagForUnderAgeOfConsent = false,
                TagForChildDirectedTreatment = false,
            });    
    }
}
