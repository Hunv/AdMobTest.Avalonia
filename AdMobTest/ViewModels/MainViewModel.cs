using Jc.AdMob.Avalonia;

namespace AdMobTest.ViewModels;

public class MainViewModel : ViewModelBase
{
    public string Greeting => "Welcome to Avalonia!";

    public MainViewModel()
    {
        AdMob.Current.Consent.OnConsentInitialized += (_, _) => AdMob.Current.Consent.ShowConsent();
    }
}
