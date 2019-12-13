
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

//using Com.Facebook.React;
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

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.Mock);
        }
    }
}
