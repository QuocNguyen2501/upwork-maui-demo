using Foundation;
using UIKit;

namespace UpworkDemo
{
    [Register("AppDelegate")]
    public class AppDelegate : MauiUIApplicationDelegate
    {
        protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();

        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            // Thay đổi màu sắc của StatusBar
            if (UIDevice.CurrentDevice.CheckSystemVersion(13, 0))
            {
                var statusBar = new UIView(UIApplication.SharedApplication.KeyWindow.WindowScene.StatusBarManager.StatusBarFrame);
                statusBar.BackgroundColor = UIColor.White;
                UIApplication.SharedApplication.KeyWindow.AddSubview(statusBar);
            }
            else
            {
                UIApplication.SharedApplication.StatusBarStyle = UIStatusBarStyle.LightContent;
            }

            return base.FinishedLaunching(app, options);
        }
    }
}
