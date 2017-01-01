using Android.Content;
using MvvmCross.Droid.Platform;
using MvvmCross.Core.ViewModels;
using MvvmCross.Platform.Platform;
using MvvmCross.Platform.Plugins;

namespace SampleMvxMapPlugin.Droid
{
    public class Setup : MvxAndroidSetup
    {
        public Setup(Context applicationContext) : base(applicationContext)
        {
        }

        protected override IMvxApplication CreateApp()
        {
            return new Core.App();
        }

        protected override IMvxTrace CreateDebugTrace()
        {
            return new DebugTrace();
        }

        protected override void AddPluginsLoaders(MvxLoaderPluginRegistry registry)
        {
            registry.Register<MvxMapPlugin.PluginLoader, MvxMapPlugin.Droid.Plugin>();

            base.AddPluginsLoaders(registry);
        }

        protected override void InitializeLastChance()
        {
            base.InitializeLastChance();
            MvxMapPlugin.PluginLoader.Instance.EnsureLoaded();
        }
    }
}
