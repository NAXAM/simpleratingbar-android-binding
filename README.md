SimpleRatingBar - Xamarin Android Binding
====

Open source project which features a simple yet powerful RatingBar alternative to Android's default.

![](https://github.com/FlyingPumba/SimpleRatingBar/raw/master/images/sample.gif)

Features
----
* Fully working `android:layout_width`: it can be set to `wrap_content`, `match_parent` or abritary dp.
* Arbitrary number of stars.
* Arbitrary step size.
* Size of stars can be controlled exactly or by setting a maximum size.
* Customizable colors in normal state (border, fill and background of stars and rating bar).
* Customizable colors in pressed state (border, fill and background of stars and rating bar).
* Customizable size separation between stars.
* Customizable border width of stars.
* Customizable stars corner radius.
* Allows to set OnRatingBarChangeListener and OnClickListener
* Stars fill can be set to start from left to right or from right to left (RTL language support).
* AnimationBuilder integrated in the view to set rating programatically with animation.

Usage
----

In your layout file:

```xml
<com.iarcuschin.simpleratingbar.SimpleRatingBar
        android:layout_width="wrap_content"
        android:layout_height="wrap_content"
        app:srb_starSize="40dp"
        app:srb_numberOfStars="5"
        app:srb_rating="3"
        app:srb_stepSize="0.5"
        app:srb_borderColor="@color/blue"
        app:srb_fillColor="@color/light_blue"
        />
```

More examples in the [sample app layouts](https://github.com/FlyingPumba/SimpleRatingBar/blob/master/simpleratingbar-sample/src/main/res/layout).

Example of setting rating with animation:

```java
SimpleRatingBar.AnimationBuilder builder = myRatingBar.getAnimationBuilder()
        .setRatingTarget(3)
        .setDuration(2000)
        .setInterpolator(new BounceInterpolator());
    builder.start();
```


Configuration
----
The view can be configured as follows:

* Set the number of stars with `app:srb_numberOfStars` / `setNumberOfStars(int)`
* Set the rating with `app:srb_rating` / `setRating(float)`
* Set step size with `app:srb_stepSize` / `setStepSize(float)`
* Set star size with `app:srb_starSize` / `setStarSize(float)`
* Set max star size with `app:srb_maxStarSize` / `setMaxStarSize(float)`
* Set separation between stars with `app:srb_starsSeparation` / `setStarsSeparation(float)`
* Set border width with `app:srb_starBorderWidth` / `setStarBorderWidth(float)`
* Set stars corner radius with `app:srb_starCornerRadius` / `setStarCornerRadius(float)`
* Set stars border color in normal state with `app:srb_borderColor` / `setBorderColor(@ColorInt int)`
* Set stars fill color in normal state with `app:srb_fillColor` / `setFillColor(@ColorInt int)`
* Set stars background color in normal state with `app:srb_starBackgroundColor` / `setStarBackgroundColor(@ColorInt int)`
* Set background color of rating bar in normal state with `app:srb_backgroundColor` / `setBackgroundColor(@ColorInt int)`
* Set stars border color in pressed state with `app:srb_pressedBorderColor` / `setPressedBorderColor(@ColorInt int)`
* Set stars fill color in pressed state with `app:srb_pressedFillColor` / `setPressedFillColor(@ColorInt int)`
* Set stars background color in pressed state with `app:srb_pressedStarBackgroundColor` / `setPressedStarBackgroundColor(@ColorInt int)`
* Set background color of rating bar in pressed state with `app:srb_pressedBackgroundColor` / `setPressedBackgroundColor(@ColorInt int)`
* Enabled/disable user interaction with `app:srb_isIndicator` / `setIsIndicator(boolean)`
* Enabled/disable border of star with `app:srb_drawBorderEnabled` / `setDrawBorderEnabled(boolean)`
* Set gravity of fill (left or right) with `app:srb_gravity` / `setGravity(Gravity)`

Download
----

```
Install-Package Naxam.SimpleRatingBar.Droid
```
