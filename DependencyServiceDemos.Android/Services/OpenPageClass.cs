using System;
using Xamarin.Forms;
using DependencyServiceDemos.Droid;
using Android.Content;

[assembly: Dependency(typeof(OpenPageClass))]

namespace DependencyServiceDemos.Droid
{
    class OpenPageClass : IOpenPage
    {
        public void OpenPage()
        {
            Forms.Context.StartActivity(new Intent(Forms.Context, typeof(RNActivity)));
        }
    }
}
