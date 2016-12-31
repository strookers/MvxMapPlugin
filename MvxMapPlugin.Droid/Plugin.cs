using MvvmCross.Platform.Plugins;

namespace MvxMapPlugin.Droid
{
    public class Plugin : IMvxPlugin
    {
        public void Load() => MapService.Initialize();
    }
}