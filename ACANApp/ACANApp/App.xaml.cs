using ACANApp.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;

namespace ACANApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MasterDetailView();
        }

        protected override void OnStart()
        {
            AppCenter.Start("ios=572b1241-0969-403c-8601-db9d17c5909c;" +
                  "uwp={Your UWP App secret here};" +
                  "android={Your Android App secret here}",
                  typeof(Analytics), typeof(Crashes));
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
