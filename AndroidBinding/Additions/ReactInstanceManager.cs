using System;

namespace Com.Facebook.React
{
    public partial class ReactInstanceManager
    {
        /// <summary>
        /// Initializes the <see cref="T:Com.Facebook.React.ReactInstanceManager"/> class.
        /// Load necessary jni libraries via static ctor.
        /// </summary>
        static ReactInstanceManager()
        {
            // Load jni libraries.
            Java.Lang.JavaSystem.LoadLibrary("imagepipeline");
            Java.Lang.JavaSystem.LoadLibrary("reactnativejni");

            Java.Lang.JavaSystem.LoadLibrary("c++_shared");
            Java.Lang.JavaSystem.LoadLibrary("fb");
            Java.Lang.JavaSystem.LoadLibrary("folly_futures");
            Java.Lang.JavaSystem.LoadLibrary("folly_json");
            Java.Lang.JavaSystem.LoadLibrary("glog");
            Java.Lang.JavaSystem.LoadLibrary("glog_init");
            Java.Lang.JavaSystem.LoadLibrary("jsc");
            Java.Lang.JavaSystem.LoadLibrary("jscexecutor");
            Java.Lang.JavaSystem.LoadLibrary("jsinspector");
            Java.Lang.JavaSystem.LoadLibrary("native-filters");
            Java.Lang.JavaSystem.LoadLibrary("native-imagetranscoder");
            Java.Lang.JavaSystem.LoadLibrary("reactnativeblob");
            Java.Lang.JavaSystem.LoadLibrary("yoga");
        }
    }
}