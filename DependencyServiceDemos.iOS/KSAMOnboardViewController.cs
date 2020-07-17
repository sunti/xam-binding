using System;
using Foundation;
using ReactNativeIOS;
using UIKit;

namespace DependencyServiceDemos.iOS
{
    public partial class KSAMOnboardViewController : UIViewController
    {

        public KSAMOnboardViewController() : base("KSAMOnboardViewController", null)
        {
            var props = new NSDictionary();
            var options = new NSDictionary();

            var url = NSBundle.MainBundle.GetUrlForResource("main", "jsbundle");
            //var url = NSUrl.FromString("http://localhost:8081/index.bundle?platform=ios");

            CFunctions.RCTRegisterModule(ObjCRuntime.Class.GetHandle(typeof(KSAMOnboardModule)));

            RCTRootView rootView = new RCTRootView(url, new NSString("KbankOnboarding"), props, options);
            base.View = rootView;
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}

