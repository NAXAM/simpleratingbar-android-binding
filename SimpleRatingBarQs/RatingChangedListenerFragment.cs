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
using Com.Iarcuschin.Simpleratingbar;

namespace SimpleRatingBarQs
{
    public class RatingChangedListenerFragment : Android.Support.V4.App.Fragment, SimpleRatingBar.IOnRatingBarChangeListener, View.IOnClickListener
    {
        SimpleRatingBar ratingBar1;
        SimpleRatingBar ratingBar2;
        SimpleRatingBar ratingBar3;
        SimpleRatingBar ratingBar4;
        SimpleRatingBar ratingBar5;
        TextView rating1;
        TextView rating2;
        TextView rating3;
        TextView rating4;
        TextView rating5;

        public void OnClick(View v)
        {
            Toast.MakeText(v.Context, "Clicked!", ToastLength.Long).Show();

        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            View view = inflater.Inflate(Resource.Layout.fragment_rating_changed_listener, container, false);
            bindViews(view);

            HasOptionsMenu = true;
            List<SimpleRatingBar> mylist;
            mylist = new List<SimpleRatingBar>()
            {
                ratingBar1, ratingBar2, ratingBar3, ratingBar4, ratingBar5
            };
            
            foreach (SimpleRatingBar srb in  mylist)
            {
                srb.SetOnRatingBarChangeListener(this);
            }

            return view;
        }

        public void OnRatingChanged(SimpleRatingBar simpleRatingBar, float rating, bool fromUser)
        {
            String text = String.Format("%.2f", rating);
            if (simpleRatingBar == ratingBar1)
            {
                rating1.Text=text;
            }
            else if (simpleRatingBar == ratingBar2)
            {
                rating2.Text=text;
            }
            else if (simpleRatingBar == ratingBar3)
            {
                rating3.Text=text;
            }
            else if (simpleRatingBar == ratingBar4)
            {
                rating4.Text=text;
            }
            else
            {
                rating5.Text=text;
            }
        }

        private void bindViews(View view)
        {
            ratingBar1 = view.FindViewById<SimpleRatingBar>(Resource.Id.ratingBar1);
            ratingBar2 = view.FindViewById<SimpleRatingBar>(Resource.Id.ratingBar2);
            ratingBar3 = view.FindViewById<SimpleRatingBar>(Resource.Id.ratingBar3);
            ratingBar4 = view.FindViewById<SimpleRatingBar>(Resource.Id.ratingBar4);
            ratingBar5 = view.FindViewById<SimpleRatingBar>(Resource.Id.ratingBar5);
            //
            rating1 = view.FindViewById<TextView>(Resource.Id.rating1);
            rating2 = view.FindViewById<TextView>(Resource.Id.rating2);
            rating3 = view.FindViewById<TextView>(Resource.Id.rating3);
            rating4 = view.FindViewById<TextView>(Resource.Id.rating4);
            rating5 = view.FindViewById<TextView>(Resource.Id.rating5);
        }
    }
}