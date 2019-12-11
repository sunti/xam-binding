using Foundation;
using UIKit;
using Xamarin.Forms;
using ReactNativeIOS;

namespace DependencyServiceDemos.iOS
{
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            global::Xamarin.Forms.Forms.Init();
            // Prevent library from beeing unlinked.
            //var temp = new ReactNative.Forms.iOS.Renderers.ReactViewRenderer();
            LoadApplication(new App());

            return base.FinishedLaunching(app, options);
        }
    }
}
