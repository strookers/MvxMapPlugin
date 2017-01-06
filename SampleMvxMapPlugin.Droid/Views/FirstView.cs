using Android.App;
using Android.Gms.Maps;
using Android.OS;
using MvvmCross.Droid.Views;

namespace SampleMvxMapPlugin.Droid.Views
{
    [Activity(Label = "View for FirstViewModel")]
    public class FirstView : MvxActivity
    {
        private GoogleMap _map;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.FirstView);
            //MapFragment mapFrag = FragmentManager.FindFragmentById<MapFragment>(Resource.Id.map);
            //_map = mapFrag.Map;

            System.Diagnostics.Debug.Write("map id: " + Resource.Id.map);
        }
    }
}
