using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using Xamarin.Forms.Platform.iOS;
using Xamarin.Forms;
using App1.iOS;

[assembly: ExportEffect(typeof(RedSliderEffect), "RedSliderEffect")]
namespace App1.iOS
{
    public class RedSliderEffect : PlatformEffect
    {
        protected override void OnAttached()
        {
            var slider = (UISlider)Control;
            slider.ThumbTintColor = UIColor.FromRGB(255, 0, 0);
            slider.MinimumTrackTintColor = UIColor.FromRGB(255, 120, 120);
            slider.MaximumTrackTintColor = UIColor.FromRGB(255, 14, 14);
        }

        protected override void OnDetached()
        {
            // Use this method if you wish to reset the control to original state
        }
    }
}