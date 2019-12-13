using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using ReactNativeIOS;
using System.Runtime.InteropServices;

namespace DependencyServiceDemos.iOS
{
    public class KSAMOnboardModule : RCTBridgeModule
    {
        //public KSAMOnboardModule()
        //{
        //}

        [Export("moduleName")]
        public static string ModuleName() => "KSAMOnboard";

        [Export("requiresMainQueueSetup")]
        public static bool RequiresMainQueueSetup => false;


        /////// External Module //////

        [Export("getUserToken:")]
        public override void GetUserToken(RCTResponseSenderBlock callback)
        {
            callback(new[] { FromObject("Jds45CgdfXTSgtrgDR4fdz=="), NSNull.Null });
        }

        [Export("__rct_export__getUserToken")]
        public static IntPtr GetUserTokenExport()
        {
            var method = new RCTMethodInfo()
            {
                jsName = string.Empty,
                objcName = "getUserToken:(RCTResponseSenderBlock)callback",
                isSync = false
            };
            
            var ptr = Marshal.AllocHGlobal(Marshal.SizeOf(method));
            Marshal.StructureToPtr(method, ptr, false);

            return ptr;
        }

        [Export("finishActivity")]
        public override void FinishActivity()
        {
            //CloseModule();
        }

        [Export("__rct_export__finishActivity")]
        public static IntPtr FinishActivityExport()
        {
            var method = new RCTMethodInfo()
            {
                jsName = string.Empty,
                objcName = "finishActivity",
                isSync = false
            };

            var ptr = Marshal.AllocHGlobal(Marshal.SizeOf(method));
            Marshal.StructureToPtr(method, ptr, false);

            return ptr;
        }
    }
}
