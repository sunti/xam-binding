
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

using Com.Facebook.React;
//using Com.Facebook.React.Shell;
//using Com.Facebook.React.Common;
//using Com.Facebook.React.Modules.Core;
using Android.Support.V7.App;
using Android.Net;
using Android.Provider;

namespace DependencyServiceDemos.Droid
{
    [Activity(Label = "RNActivity")]
    public class RNActivity : Activity
    {
        RCTRootView mReactRootView;
        ReactInstanceManager mReactInstanceManager;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            //Create your application here
            if (Build.VERSION.SdkInt >= BuildVersionCodes.M)
            {
                if (!Settings.CanDrawOverlays(this))
                {
                    Intent intent = new Intent(Settings.ActionManageOverlayPermission,Android.Net.Uri.Parse("package:" + PackageName));
                    StartActivityForResult(intent,1);
                }
            }

            mReactRootView = new ReactRootView(this);
            mReactInstanceManager = ReactInstanceManager.Builder()
                    .SetApplication(Application)
                    .SetBundleAssetName("index.android.bundle")
                    .SetJSMainModulePath("index")
                    .AddPackage(new MainReactPackage())
#if DEBUG
                    .SetUseDeveloperSupport(true)
#else
                    .SetUseDeveloperSupport(false)
#endif
                    .SetInitialLifecycleState(LifecycleState.Resumed)
                    .Build();

            mReactRootView.StartReactApplication(mReactInstanceManager, "xxxx", null);

            SetContentView(mReactRootView);
        }
    }
}
