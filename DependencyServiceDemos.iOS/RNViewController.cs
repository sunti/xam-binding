﻿using System;
using Foundation;
//using ReactNative.iOS;
using ReactNativeIOS;
using UIKit;

namespace DependencyServiceDemos.iOS
{
    public partial class RNViewController : UIViewController
    {

        public RNViewController() : base("RNViewController", null)
        {
            var props = new NSDictionary();
            var options = new NSDictionary();

            var url = NSBundle.MainBundle.GetUrlForResource("main", "jsbundle");
            //var url = NSUrl.FromString("http://localhost:8081/index.bundle?platform=ios");

            RCTRootView rootView = new RCTRootView(url, new NSString("xxxx"), props, options);
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
