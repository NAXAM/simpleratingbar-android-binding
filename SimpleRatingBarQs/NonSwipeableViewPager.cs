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
using Android.Support.V4.View;
using Android.Util;

namespace SimpleRatingBarQs
{
    public class NonSwipeableViewPager: ViewPager
    {
        public NonSwipeableViewPager(Context context): base(context)
        {
        }

        public NonSwipeableViewPager(Context context, IAttributeSet attrs):base(context,attrs)
        {
        }
        public override bool OnInterceptTouchEvent(MotionEvent ev)
        {
            return false;
        }
        public override bool OnTouchEvent(MotionEvent e)
        {
            return false;
        }


    }
}