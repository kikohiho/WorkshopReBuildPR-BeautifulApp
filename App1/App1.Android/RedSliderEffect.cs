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
using Xamarin.Forms.Platform.Android;
using Android.Graphics;
using Xamarin.Forms;
using App1.Droid;

[assembly: ExportEffect(typeof(RedSliderEffect), "RedSliderEffect")]
namespace App1.Droid
{
    public class RedSliderEffect : PlatformEffect
    {
        protected override void OnAttached()
        {
            var seekBar = (SeekBar)Control;
            seekBar.ProgressDrawable.SetColorFilter(new PorterDuffColorFilter(Xamarin.Forms.Color.Red.ToAndroid(), PorterDuff.Mode.SrcIn));
            seekBar.Thumb.SetColorFilter(new PorterDuffColorFilter(Xamarin.Forms.Color.Red.ToAndroid(), PorterDuff.Mode.SrcIn));
        }

        protected override void OnDetached()
        {
            // Use this method if you wish to reset the control to original state
        }
    }
}