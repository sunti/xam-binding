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
            UIApplication.SharedApplication.KeyWindow.RootViewController = new KSAMOnboardViewController();
        }

        public void ClosePage()
        {
            //UIApplication.SharedApplication.KeyWindow.RootViewController = new KSAMOnboardViewController();
            //
        }
    }
}
