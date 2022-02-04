 using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Elemendide_App
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            //InitializeComponent();
            StackLayout st = new StackLayout();
            Button Ent_btn = new Button()
            {
                Text = "Entry",
                BackgroundColor = Color.Red,
            };

            Button Timer_btn = new Button()
            {
                Text = "Timer",
                BackgroundColor = Color.Red,
            };

            Button BoxView_btn = new Button()
            {
                Text = "BoxView",
                BackgroundColor = Color.Red,
            };

            BoxView_btn.Clicked += BoxView_Clicked;
            
            st.Children.Add(Ent_btn);
            st.Children.Add(Timer_btn);
            st.Children.Add(BoxView_btn);
            st.BackgroundColor = Color.AntiqueWhite;
            Content = st;
            Ent_btn.Clicked += Ent_btn_Clicked;
            Timer_btn.Clicked += Timer_btn_Clicked;
        }

        private async void BoxView_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BoxView_Page());
        }

        private  async void Timer_btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TimerPage());
        }

        private async void Ent_btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Entry_Page());
        }
    }
}
