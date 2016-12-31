using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

using MvvmCross.Platform;
using MvvmCross.Platform.Droid.Platform;
using MvvmCross.Platform.Platform;

using MvxMapPlugin;

namespace MvxMapPlugin.Droid
{
    public class MapService : BaseMapService
    {
        internal static void Initialize()
            => Mvx.RegisterSingleton<IMapService>(new MapService());

        private MapService() { }
    }
}