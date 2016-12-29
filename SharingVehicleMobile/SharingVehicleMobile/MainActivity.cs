using Android.App;
using Android.Widget;
using Android.OS;

namespace SharingVehicleMobile
{
    [Activity(Label = "SharingVehicleMobile", MainLauncher = true, Icon = "@drawable/sharing48")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView (Resource.Layout.Main);
        }
    }
}

