using ACANApp.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ACANApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MasterDetailViewACAN();
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
