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
using Android.Support.Annotation;

namespace SimpleRatingBarQs
{
    public class StarsSeparationFragment : Android.Support.V4.App.Fragment
    {
        SimpleRatingBar ratingBar1;
        SimpleRatingBar ratingBar2;
        SimpleRatingBar ratingBar3;
        SimpleRatingBar ratingBar4;
        SimpleRatingBar ratingBar5;

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            View view = inflater.Inflate(Resource.Layout.fragment_stars_separation, container, false);
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
            float limit = TypedValue.ApplyDimension(ComplexUnitType.Dip, 25, Resources.DisplayMetrics);
            // Handle item selection
            switch (item.ItemId)
            {
                case Resource.Id.menu_action_refresh:
                    if (ratingBar1.GetStarsSeparation(0) <= limit)
                    {
                        ratingBar1.SetStarsSeparation(ratingBar1.GetStarsSeparation(Dimension.Dp) + 4, Dimension.Dp);
                        ratingBar2.SetStarsSeparation(ratingBar2.GetStarsSeparation(Dimension.Dp) + 4, Dimension.Dp);
                        ratingBar3.SetStarsSeparation(ratingBar3.GetStarsSeparation(Dimension.Dp) + 4, Dimension.Dp);
                        ratingBar4.SetStarsSeparation(ratingBar4.GetStarsSeparation(Dimension.Dp) + 4, Dimension.Dp);
                        ratingBar5.SetStarsSeparation(ratingBar5.GetStarsSeparation(Dimension.Dp) + 4, Dimension.Dp);
                    }
                    else
                    {
                        ratingBar1.SetStarsSeparation(4, Dimension.Dp);
                        ratingBar2.SetStarsSeparation(6, Dimension.Dp);
                        ratingBar3.SetStarsSeparation(8, Dimension.Dp);
                        ratingBar4.SetStarsSeparation(10, Dimension.Dp);
                        ratingBar5.SetStarsSeparation(12, Dimension.Dp);
                    }
                    return false;
                default:
                    return base.OnOptionsItemSelected(item);
            }
        }
    }
}