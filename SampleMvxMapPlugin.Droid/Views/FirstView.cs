using Android.App;
using Android.OS;
using MvvmCross.Droid.Views;

namespace SampleMvxMapPlugin.Droid.Views
{
    [Activity(Label = "View for FirstViewModel")]
    public class FirstView : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.FirstView);

            System.Diagnostics.Debug.Write("map id: " + Resource.Id.map.ToString());
        }
    }
}
