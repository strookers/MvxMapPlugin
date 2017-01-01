using Android.Runtime;
using MvvmCross.Platform;
using MvvmCross.Platform.Plugins;

namespace MvxMapPlugin.Droid
{
    //public class Plugin : IMvxPlugin
    //{
    //    public void Load() => MvxMap.Initialize();
    //}

    public class Plugin : IMvxPlugin
    {
        [Preserve(AllMembers = true)]
        public void Load()
        {
            Mvx.RegisterType<IMvxMap, MvxMap>();
        }
    }
}