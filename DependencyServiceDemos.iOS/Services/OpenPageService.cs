using System.Diagnostics;
using DependencyServiceDemos.iOS;
using Foundation;
//using ReactNative.iOS;
using UIKit;
using Xamarin.Forms;

[assembly: Dependency(typeof(OpenPageService))]

namespace DependencyServiceDemos.iOS
{
    public class OpenPageService : IOpenPage
    {
        public void OpenPage()
        {
            UIApplication.SharedApplication.KeyWindow.RootViewController = new RNViewController();

            //var props = new NSDictionary();
            //var options = new NSDictionary();

            //var url = NSBundle.MainBundle.GetUrlForResource("xxxx.app/main", "jsbundle");
            ////var url = NSUrl.FromString("http://localhost:8081/index.bundle?platform=ios");
            //RCTRootView rootView = new RCTRootView(url, new NSString("xxxx"), props, options);
            //var vc = new UIViewController();
            //vc.View = rootView;
            //UIApplication.SharedApplication.KeyWindow.RootViewController = vc;

        }
    }
}
