﻿using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;
/*
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
*/

namespace ACANApp.iOS
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the 
    // User Interface of the application, as well as listening (and optionally responding) to 
    // application events from iOS.
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        //
        // This method is invoked when the application has loaded and is ready to run. In this 
        // method you should instantiate the window, load the UI into it and then make the window
        // visible.
        //
        // You have 17 seconds to return from this method, or iOS will terminate your application.
        //
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            global::Xamarin.Forms.Forms.Init();
            LoadApplication(new App());

            /*
            AppCenter.Start("ios=572b1241-0969-403c-8601-db9d17c5909c;" +
                  "uwp={Your UWP App secret here};" +
                  "android={Your Android App secret here}",
                typeof(Analytics), typeof(Crashes));
             */

            return base.FinishedLaunching(app, options);
        }
    }
}
