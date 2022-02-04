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
    public partial class TimerPage : ContentPage
    {
        public TimerPage()
        {
            InitializeComponent();
        }

        bool on_off = true;
        private async void ShowTime()
        {
            int a = 0;
            int b = 0;
            while (on_off)
            {
                timer_btn.Text = DateTime.Now.ToString("T");
                
                await Task.Delay(1000);
                a++;
                if (a == 5)
                {
                    lbl.Text = "True";
                    
                }
                else if (a > 10)
                {
                    lbl.Text = "False";
                }
                if (a == 15)
                {
                    a = 0;
                    lbl.Text = "Vajutatud";
                }
            }
        }

        private void timer_btn_Clicked(object sender, EventArgs e)
        {
            if (on_off)
            {
                on_off = false;
            }
            else
            {
                on_off = true;
                ShowTime();
            }
        }

        private async void tagasi_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            lbl.Text = "Vajutatud";
        }
    }
}