namespace UpworkDemo
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            Microsoft.Maui.Handlers.EntryHandler.Mapper.AppendToMapping(nameof(Entry), (h, v) =>
            {
#if ANDROID
            h.PlatformView.BackgroundTintList = Android.Content.Res.ColorStateList.ValueOf(Android.Graphics.Color.Transparent);
                var color = Color.FromHex("#297721");
                h.PlatformView.TextCursorDrawable.SetTint(color.ToInt());
#endif
            });

            Microsoft.Maui.Handlers.SearchBarHandler.Mapper.AppendToMapping(nameof(SearchBar), (h, v) =>
            {
#if ANDROID
                Android.Widget.LinearLayout linearLayout = h.PlatformView.GetChildAt(0) as Android.Widget.LinearLayout;
                linearLayout = linearLayout.GetChildAt(2) as Android.Widget.LinearLayout;
                linearLayout = linearLayout.GetChildAt(1) as Android.Widget.LinearLayout;
                linearLayout.Background = null;
#endif
            });

            Microsoft.Maui.Handlers.ToolbarHandler.Mapper.AppendToMapping(nameof(ToolbarItem), (h, v) =>
            {
#if ANDROID
                h.PlatformView.OverflowIcon.SetTint(Android.Graphics.Color.Black);
#endif
            });

            MainPage = new AppShell();
        }
    }
}
