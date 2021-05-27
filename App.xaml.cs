using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XFAApp1.Services;
using XFAApp1.Views;

namespace XFAApp1
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new MainPage();
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
