using Android.App;
using Android.Content.PM;
using Android.OS;

namespace UpworkDemo
{
    [Activity(Theme = "@style/Maui.SplashTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize | ConfigChanges.Density)]
    public class MainActivity : MauiAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Thay đổi màu sắc của StatusBar
            Window?.SetStatusBarColor(Android.Graphics.Color.White);
        }
    }
}
