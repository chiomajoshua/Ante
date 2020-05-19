using Ante.Helpers;
using Ante.Pages.Onboarding;
using Ante.ViewModels;
using System;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;
using Xamarin.Forms.Xaml;

namespace Ante
{
    public partial class App : Xamarin.Forms.Application
    {
        public App()
        {
            
            InitializeComponent();
            Current.On<Android>().UseWindowSoftInputModeAdjust(WindowSoftInputModeAdjust.Resize);
            MainPage = new Controls.ImageNavigationPage(new WalkThroughPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }

        public Essentials Essentials
        {
            get;
            set;
        }
    }
}
