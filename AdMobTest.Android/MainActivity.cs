using Android.App;
using Android.Content.PM;

using Avalonia;
using Avalonia.Android;
using Avalonia.ReactiveUI;
using Jc.AdMob.Avalonia;
using Jc.AdMob.Avalonia.Android;

namespace AdMobTest.Android;

[Activity(
    Label = "AdMobTest.Android",
    Theme = "@style/MyTheme.NoActionBar",
    Icon = "@drawable/icon",
    MainLauncher = true,
    ConfigurationChanges = ConfigChanges.Orientation | ConfigChanges.ScreenSize | ConfigChanges.UiMode)]
public class MainActivity : AvaloniaMainActivity<App>
{
    protected override AppBuilder CustomizeAppBuilder(AppBuilder builder)
    {
        return base.CustomizeAppBuilder(builder)
            .WithInterFont()
            .UseReactiveUI()
            .UseAdMob(this, new AdMobOptions
            {
                TestDeviceIds = [],
                TagForUnderAgeOfConsent = false,
                TagForChildDirectedTreatment = false
            });
    }
}
