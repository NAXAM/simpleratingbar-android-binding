using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using Com.Iarcuschin.Simpleratingbar;

namespace SimpleRatingBarQs
{
    public class BorderWidthFragment : Android.Support.V4.App.Fragment
    {
        SimpleRatingBar ratingBar1;
        SimpleRatingBar ratingBar2;
        SimpleRatingBar ratingBar3;
        SimpleRatingBar ratingBar4;
        SimpleRatingBar ratingBar5;


        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            View view = inflater.Inflate(Resource.Layout.fragment_border_width, container, false);
            bindViews(view);

            HasOptionsMenu = true;

            return view;
        }
        private void bindViews(View view)
        {
            ratingBar1 = view.FindViewById<SimpleRatingBar>(Resource.Id.ratingBar1);
            ratingBar2 = view.FindViewById<SimpleRatingBar>(Resource.Id.ratingBar2);
            ratingBar3 = view.FindViewById<SimpleRatingBar>(Resource.Id.ratingBar3);
            ratingBar4 = view.FindViewById<SimpleRatingBar>(Resource.Id.ratingBar4);
            ratingBar5 = view.FindViewById<SimpleRatingBar>(Resource.Id.ratingBar5);

        }
        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            switch (item.ItemId)
            {
                case Resource.Id.menu_action_refresh:
                    if (ratingBar1.StarBorderWidth <= 9)
                    {
                        ratingBar1.StarBorderWidth=ratingBar1.StarBorderWidth + 1;
                        ratingBar2.StarBorderWidth=ratingBar2.StarBorderWidth + 1;
                        ratingBar3.StarBorderWidth=ratingBar3.StarBorderWidth + 1;
                        ratingBar4.StarBorderWidth=ratingBar4.StarBorderWidth + 1;
                        ratingBar5.StarBorderWidth=ratingBar5.StarBorderWidth + 1;
                    }
                    else
                    {
                        ratingBar1.StarBorderWidth=5;
                        ratingBar2.StarBorderWidth = 6;
                        ratingBar3.StarBorderWidth=7;
                        ratingBar4.StarBorderWidth=8;
                        ratingBar5.StarBorderWidth=9;
                    }
                    return false;
                default:
                    return base.OnOptionsItemSelected(item);
            }
        }
    }
}