using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using RestService.View;

namespace RestService
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new DemoRestServicePage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
