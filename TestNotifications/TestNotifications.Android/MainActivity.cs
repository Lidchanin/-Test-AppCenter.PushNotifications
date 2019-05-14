using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.OS;
using Microsoft.AppCenter.Push;

namespace TestNotifications.Droid
{
    [Activity(
        Label = "TestNotifications", 
        Icon = "@mipmap/icon", 
        Theme = "@style/MainTheme", 
        LaunchMode = LaunchMode.SingleInstance,
        MainLauncher = true, 
        ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            LoadApplication(new App());
        }

        //If (and only if) your launcher activity uses a launchMode of singleTop, singleInstance or singleTask
        protected override void OnNewIntent(Intent intent)
        {
            base.OnNewIntent(intent);
            Push.CheckLaunchedFromNotification(this, intent);
        }
    }
}