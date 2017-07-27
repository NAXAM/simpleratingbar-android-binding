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
    public class NumberOfStarsFragment : Android.Support.V4.App.Fragment
    {
        SimpleRatingBar ratingBar1;
        SimpleRatingBar ratingBar2;
        SimpleRatingBar ratingBar3;
        SimpleRatingBar ratingBar4;
        SimpleRatingBar ratingBar5;

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            View view = inflater.Inflate(Resource.Layout.fragment_number_of_stars, container, false);
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
                    if (ratingBar1.NumberOfStars == 5)
                    {
                        ratingBar1.NumberOfStars=1;
                        ratingBar2.NumberOfStars=2;
                        ratingBar3.NumberOfStars=3;
                        ratingBar4.NumberOfStars=4;
                        ratingBar5.NumberOfStars=5;
                    }
                    else
                    {
                        ratingBar1.NumberOfStars=5;
                        ratingBar2.NumberOfStars=4;
                        ratingBar3.NumberOfStars=3;
                        ratingBar4.NumberOfStars=2;
                        ratingBar5.NumberOfStars=1;
                    }
                    return false;
                default:
                    return base.OnOptionsItemSelected(item);
            }
        }
    }
}