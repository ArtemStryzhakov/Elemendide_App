using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Elemendide_App
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BoxView_Page : ContentPage
    {
        BoxView box;
        Label lbl_click;
        TapGestureRecognizer tap;
        int click = 0;
        public BoxView_Page()
        {
            box = new BoxView()
            {
                Color = Color.Blue,
                CornerRadius = 50,
                WidthRequest = 200,
                HeightRequest = 400,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            lbl_click = new Label()
            {
                Text = "Click",
                BackgroundColor = Color.White,
                TextColor = Color.Black,
            };

            tap = new TapGestureRecognizer();
            tap.Tapped += Tap_Tapped;
            box.GestureRecognizers.Add(tap);

            StackLayout st = new StackLayout { Children = { box, lbl_click } };
            Content = st;
        }

        private void Tap_Tapped(object sender, EventArgs e)
        {
            click++;
            lbl_click.Text = $"{click}";
        }
    }
}