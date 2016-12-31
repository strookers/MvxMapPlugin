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

namespace MvxMapPlugin.Droid
{
    public class MapService : BaseMapService
    {
        internal static void Initialize()
            => Mvx.RegisterSingleton<IMapService>(new MapService());

        private Activity Activity => Mvx.Resolve<IMvxAndroidCurrentTopActivity>().Activity;

        private GoogleMap _map;

        private MapService()
        {
            MapFragment mapFragment = Activity.FragmentManager.FindFragmentById<MapFragment>(Resource.Id.map);
            _map = mapFragment.Map;
        }

        private void UpdateCameraPosition(LatLng pos)
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

        private Void MarkOnMap(string title, LatLng pos, string metaText)
        {
            Marker m = null;

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

        private void MakePolyline(LatLng[] latLngPoints)
        {
                PolylineOptions polylineoption = new PolylineOptions();
                polylineoption.InvokeColor(Android.Graphics.Color.Red);
                polylineoption.Geodesic(true);
                polylineoption.Add(latLngPoints);

                _map.AddPolyline(polylineoption);
        }
    }
}