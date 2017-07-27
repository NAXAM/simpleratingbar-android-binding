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
using Android.Support.V7.App;
using Android.Support.Design.Widget;
using Android.Support.V4.App;
using Android.Support.V4.View;
using Java.Lang;

namespace SimpleRatingBarQs
{
    [Activity(Label = "MainActivity", MainLauncher = true, Theme = "@style/AppTheme")]
    public class MainActivity : AppCompatActivity
    {


        NonSwipeableViewPager viewpager;
        TabLayout tabLayout;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_main);
            bindViews();
            viewpager.Adapter = new myPagerAdapter(SupportFragmentManager);
            tabLayout.SetupWithViewPager(viewpager);

            SupportActionBar.Elevation=0f;

        }
        private void bindViews()
        {
            viewpager = FindViewById<NonSwipeableViewPager>(Resource.Id.viewpager);
            tabLayout = FindViewById<TabLayout>(Resource.Id.tab_layout);

        }

       
        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater inflater = MenuInflater;
            inflater.Inflate(Resource.Menu.menu_main, menu);
            return true;
        }
        private class myPagerAdapter : FragmentStatePagerAdapter
        {
            public myPagerAdapter(Android.Support.V4.App.FragmentManager fm) : base(fm)
            {
            }
            public override int Count => 9;

            public override Android.Support.V4.App.Fragment GetItem(int position)
            {
                switch (position)
                {
                    case 0:
                        return new AnimatedFragment();
                    case 1:
                        return new NumberOfStarsFragment();
                    case 2:
                        return new SizeOfStarsFragment();
                    case 3:
                        return new StarsSeparationFragment();
                    case 4:
                        return new BorderWidthFragment();
                    case 5:
                        return new CornerRadiusFragment();
                    case 6:
                        return new StepSizeAndGravityFragment();
                    case 7:
                        return new BackgroundColorsFragment();
                    default:
                        return new RatingChangedListenerFragment();
                }
            }

            public override ICharSequence GetPageTitleFormatted(int position)
            {
                switch (position)
                {
                    case 0:
                        return new Java.Lang.String("Animated");
                    case 1:
                        return new Java.Lang.String("Number of Stars");
                    case 2:
                       return  new Java.Lang.String("Size of Stars");
                    case 3:
                        return new Java.Lang.String("Separation");
                    case 4:
                        return new Java.Lang.String("Border width");
                    case 5:
                        return new Java.Lang.String("Corner radius");
                    case 6:
                        return new Java.Lang.String("Step size and Gravity");
                    case 7:
                        return new Java.Lang.String("Background color");
                    default:
                        return new Java.Lang.String("Rating changed Listener");
                }
            }
        }


    }
}