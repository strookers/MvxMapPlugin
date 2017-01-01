using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Gms.Maps;
using Android.Gms.Maps.Model;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

using MvvmCross.Platform;
using MvvmCross.Platform.Droid.Platform;

using MvxMapPlugin;
using MvxMapPlugin.Models;

namespace MvxMapPlugin.Droid
{
    [Preserve(AllMembers = true)]
    public class MvxMap : IMvxMap
    {
        public Activity Activity => Mvx.Resolve<IMvxAndroidCurrentTopActivity>().Activity;

        public GoogleMap _map;

        //private MvxMap()
        //{
        //    System.Diagnostics.Debug.Write("Tester her: ");
        //    MapFragment mapFragment = Activity.FragmentManager.FindFragmentById<MapFragment>(Activity.Resources.GetIdentifier("map", "id", Activity.PackageName));
        //    _map = mapFragment.Map;
        //}

        public MvxMap()
        {
            System.Diagnostics.Debug.Write("ctor: works");

            MapFragment mapFragment = Activity.FragmentManager.FindFragmentById<MapFragment>(Activity.Resources.GetIdentifier("map", "id", Activity.PackageName));
            _map = mapFragment.Map;

            System.Diagnostics.Debug.Write("Aktivity title: " + Activity.Title);
        }

        public void UpdateCameraPosition(LatLngNew pos)
        {
            LatLng position = new LatLng(pos.lat, pos.lng);
            try
            {
                CameraPosition.Builder builder = CameraPosition.InvokeBuilder();
                builder.Target(position);
                builder.Zoom(12);
                builder.Bearing(45);
                builder.Tilt(10);
                CameraPosition cameraPosition = builder.Build();
                CameraUpdate cameraUpdate = CameraUpdateFactory.NewCameraPosition(cameraPosition);
                _map.AnimateCamera(cameraUpdate);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

            }
        }

        public void MarkOnMap(string title, LatLngNew pos, string metaText)
        {
            LatLng position = new LatLng(pos.lat, pos.lng);
                try
                {
                    MarkerOptions marker = new MarkerOptions();
                    marker.SetTitle(title);
                    marker.SetPosition(position); //Resource.Drawable.BlueDot
                    marker.SetSnippet(metaText);

                    _map.AddMarker(marker);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }

        public void MakePolyline(List<LatLngNew> locations)
        {
            LatLng[] latLngPoints = new LatLng[locations.Count];
            int index = 0;
            foreach (LatLngNew loc in locations)
            {
                latLngPoints[index++] = new LatLng(loc.lat, loc.lng);
            }

            PolylineOptions polylineoption = new PolylineOptions();
                polylineoption.InvokeColor(Android.Graphics.Color.Red);
                polylineoption.Geodesic(true);
                polylineoption.Add(latLngPoints);

                _map.AddPolyline(polylineoption);
        }

        public void Test(string test)
        {
            Toast.MakeText(Activity, test, ToastLength.Long).Show();
        }
    }
}