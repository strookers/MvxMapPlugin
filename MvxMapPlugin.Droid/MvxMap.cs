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
        //internal static void Initialize()
        //    => Mvx.RegisterSingleton<IMvxMap>(new MvxMap());

        //private Activity Activity => Mvx.Resolve<IMvxAndroidCurrentTopActivity>().Activity;

        private GoogleMap _map;

        private MvxMap()
        {
            System.Diagnostics.Debug.Write("Tester her: ");
            //MapFragment mapFragment = Activity.FragmentManager.FindFragmentById<MapFragment>(Activity.Resources.GetIdentifier("map", "id", Activity.PackageName));
            //_map = mapFragment.Map;
        }

        public void NativeUpdateCameraPosition(LatLng pos)
        {
            try
            {
                CameraPosition.Builder builder = CameraPosition.InvokeBuilder();
                builder.Target(pos);
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

        public void NativeMarkOnMap(string title, LatLng pos, string metaText)
        {
                try
                {
                    MarkerOptions marker = new MarkerOptions();
                    marker.SetTitle(title);
                    marker.SetPosition(pos); //Resource.Drawable.BlueDot
                    marker.SetSnippet(metaText);

                    _map.AddMarker(marker);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }

        public void UpdateCameraPosition()
        {
            throw new NotImplementedException();
        }

        public void MarkOnMap()
        {
            throw new NotImplementedException();
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
    }
}