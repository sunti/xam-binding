using System;
using Xamarin.Forms;

namespace DependencyServiceDemos
{
    public partial class MainPage : TabbedPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void OnGetDeviceOrientationButtonClicked(object sender, EventArgs e)
        {
            DeviceOrientation orientation = DependencyService.Get<IDeviceOrientationService>().GetOrientation();
            orientationLabel.Text = orientation.ToString();
        }

        void OnSpeakButtonClicked(object sender, EventArgs e)
        {
            DependencyService.Get<IOpenPage>().OpenPage();

        }
    }
}
