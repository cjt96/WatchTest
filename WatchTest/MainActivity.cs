using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Support.Wearable.Views;
using Android.Support.V4.App;
using Android.Support.V4.View;
using Java.Interop;
using Android.Views.Animations;
using Android.Content.Res;
using PogoLib;
using Android.Util;

namespace WatchTest
{
    [Activity(Label = "WatchTest", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity, View.IOnApplyWindowInsetsListener
    {
        Resources res;
        GridViewPager pager;
        PogoClient client;


        public WindowInsets OnApplyWindowInsets(View v, WindowInsets insets)
        {
            bool round = insets.IsRound;
            int rowMargin = res.GetDimensionPixelOffset(Resource.Dimension.page_row_margin);
            int colMargin = res.GetDimensionPixelOffset(
                                round ? Resource.Dimension.page_column_margin_round : Resource.Dimension.page_column_margin);
            pager.SetPageMargins(rowMargin, colMargin);
            return insets;
        }

        protected async override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.activity_main);
            client = new PogoClient(190, 52.6229622651157, -2.12332305297419, "PogoTrackerCW", "SnHackable25@!");
            res = Resources;
            pager = (GridViewPager)FindViewById(Resource.Id.pager);
            pager.SetOnApplyWindowInsetsListener(this);
            pager.Adapter = new GridPagerAdapter(this, FragmentManager);
            await client.LogIn();
            Log.Debug("LogIn", client.LoggedIn.ToString());
        }
    }
}


