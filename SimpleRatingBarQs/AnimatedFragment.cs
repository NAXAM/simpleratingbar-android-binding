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
using Android.Animation;
using Android.Views.Animations;

namespace SimpleRatingBarQs
{

    public class AnimatedFragment : Android.Support.V4.App.Fragment
    {
        SimpleRatingBar ratingBar1;
        SimpleRatingBar ratingBar2;
        SimpleRatingBar ratingBar3;
        SimpleRatingBar ratingBar4;
        SimpleRatingBar ratingBar5;

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            View view = inflater.Inflate(Resource.Layout.fragment_animated, container, false);
            bindViews(view);
            startAnimations();

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

        private void startAnimations()
        {
            ratingBar1.GetAnimationBuilder()
       .SetRepeatCount(ValueAnimator.Infinite)
       .SetRepeatMode((int)ValueAnimatorRepeatMode.Reverse)
       .SetInterpolator(new LinearInterpolator())
       .SetRatingTarget(4)
       .Start();

            ratingBar2.GetAnimationBuilder()
                .SetRepeatCount(ValueAnimator.Infinite)
                .SetRepeatMode((int)ValueAnimatorRepeatMode.Reverse)
                .SetInterpolator(new AccelerateInterpolator(1.5f))
                .SetRatingTarget(4)
                .Start();

            ratingBar3.GetAnimationBuilder()
                .SetRepeatCount(ValueAnimator.Infinite)
                .SetRepeatMode((int)ValueAnimatorRepeatMode.Reverse)
                .SetInterpolator(new DecelerateInterpolator(1.5f))
                .SetRatingTarget(4)
                .SetDuration(1500)
                .Start();

            ratingBar4.GetAnimationBuilder()
                .SetRepeatCount(ValueAnimator.Infinite)
                .SetRepeatMode((int)ValueAnimatorRepeatMode.Reverse)
                .SetInterpolator(new BounceInterpolator())
                .SetRatingTarget(4)
                .Start();

            ratingBar5.GetAnimationBuilder()
                .SetRepeatCount(ValueAnimator.Infinite)
                .SetRepeatMode((int)ValueAnimatorRepeatMode.Reverse)
                .SetInterpolator(new OvershootInterpolator(2f))
                .SetRatingTarget(4)
                .Start();
        }
    }
}