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
    public class CornerRadiusFragment : Android.Support.V4.App.Fragment
    {
        SimpleRatingBar ratingBar1;
        SimpleRatingBar ratingBar2;
        SimpleRatingBar ratingBar3;
        SimpleRatingBar ratingBar4;
        SimpleRatingBar ratingBar5;

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            View view = inflater.Inflate(Resource.Layout.fragment_corner_radius, container, false);
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
                    if (ratingBar1.StarCornerRadius <= 10)
                    {
                        ratingBar1.StarCornerRadius = ratingBar1.StarCornerRadius + 2;
                        ratingBar2.StarCornerRadius = ratingBar2.StarCornerRadius + 2;
                        ratingBar3.StarCornerRadius = ratingBar3.StarCornerRadius + 2;
                        ratingBar4.StarCornerRadius = ratingBar4.StarCornerRadius + 2;
                        ratingBar5.StarCornerRadius = ratingBar5.StarCornerRadius + 2;
                    }
                    else
                    {
                        ratingBar1.StarCornerRadius = 0;
                        ratingBar2.StarCornerRadius = 2;
                        ratingBar3.StarCornerRadius = 4;
                        ratingBar4.StarCornerRadius = 6;
                        ratingBar5.StarCornerRadius = 8;
                    }
                    return false;
                default:
                    return base.OnOptionsItemSelected(item);
            }
        }
    }
}