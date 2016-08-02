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
using Android.Support.Wearable.Views;
using PogoLib.Wearable;
using PogoLib;

namespace WatchTest
{
    public class GridPagerAdapter : FragmentGridPagerAdapter
    {
        private readonly Context context;
        private DynamicPage[][] Pages;

        public GridPagerAdapter(Context ctx, FragmentManager gm) : base(gm)
        {
            context = ctx;
        }

        public void BuildPages()
        {
            Pages = new DynamicPage[][]
            {
                new DynamicPage[] {new DynamicPage()}
            }
        }

        public override int RowCount
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override int GetColumnCount(int p0)
        {
            throw new NotImplementedException();
        }

        public override Fragment GetFragment(int p0, int p1)
        {
            throw new NotImplementedException();
        }
    }
}