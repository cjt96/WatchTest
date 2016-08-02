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

namespace WatchTest
{
    public class LocationServiceBinder : Binder
    {
        public bool IsBound { get; set; }
        protected LocationService service;
        public LocationService Service
        {
            get { return Service; }
        }

        public LocationServiceBinder(LocationService service)
        {
            this.service = service;
        }
    }
}