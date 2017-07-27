using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AnimatedButton : ContentPage
    {
        bool AnimationinProgress = false;
        public AnimatedButton()
        {
            InitializeComponent();
            button.Opacity = 0;
            button.Clicked += Button_Clicked;
            button.Scale = 0.5;
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            if (AnimationinProgress)
                return;
            AnimationinProgress = true;
            await button.ScaleTo(0.7, 50, Easing.SinIn);
            await button.ScaleTo(1.3, 50, Easing.SinIn);
            await button.ScaleTo(1, 50, Easing.SinIn);
            AnimationinProgress = false;
        }

        protected override async void OnAppearing()
        {
            System.Diagnostics.Debug.WriteLine("OnAppearing Called");
            await Task.WhenAll(
                button.ScaleTo(1, 1000, Easing.SinInOut),
                button.FadeTo(1, 1000, Easing.Linear)
            );

            await Task.Delay(500);
            Button button2 = new Button { Opacity = 0, Text= "Hello!", BackgroundColor = Color.Black, TextColor=Color.White, Scale=0.5};
            stack.Children.Add(button2);
            await Task.WhenAll(
                button2.ScaleTo(1, 1000, Easing.SinInOut),
                button2.FadeTo(1, 1000, Easing.Linear)
            );
            base.OnAppearing();

        }
    }
}