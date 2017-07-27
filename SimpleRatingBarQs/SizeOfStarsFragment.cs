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
    public class SizeOfStarsFragment : Android.Support.V4.App.Fragment
    {
        SimpleRatingBar ratingBar1;
        SimpleRatingBar ratingBar2;
        SimpleRatingBar ratingBar3;
        SimpleRatingBar ratingBar4;
        SimpleRatingBar ratingBar5;
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            View view = inflater.Inflate(Resource.Layout.fragment_size_of_stars, container, false);
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
            float limit = TypedValue.ApplyDimension(ComplexUnitType.Dip, 50, Resources.DisplayMetrics);
            // Handle item selection
            switch (item.ItemId)
            {
                case Resource.Id.menu_action_refresh:
                    if (ratingBar1.StarSize <= limit)
                    {
                        ratingBar1.StarSize=ratingBar1.StarSize + 20;
                        ratingBar2.StarSize=ratingBar2.StarSize + 20;
                        ratingBar3.StarSize=ratingBar3.StarSize + 20;
                        ratingBar4.StarSize=ratingBar4.StarSize + 20;
                        ratingBar5.StarSize=ratingBar5.StarSize + 20;
                    }
                    else
                    {
                        ratingBar1.StarSize=TypedValue.ApplyDimension(ComplexUnitType.Dip, 10, Resources.DisplayMetrics);
                        ratingBar2.StarSize=TypedValue.ApplyDimension(ComplexUnitType.Dip, 20, Resources.DisplayMetrics);
                        ratingBar3.StarSize=TypedValue.ApplyDimension(ComplexUnitType.Dip, 30, Resources.DisplayMetrics);
                        ratingBar4.StarSize=TypedValue.ApplyDimension(ComplexUnitType.Dip, 40, Resources.DisplayMetrics);
                        ratingBar5.StarSize=TypedValue.ApplyDimension(ComplexUnitType.Dip, 50, Resources.DisplayMetrics);
                    }
                    return false;
                default:
                    return base.OnOptionsItemSelected(item);
            }
        }
    }
}