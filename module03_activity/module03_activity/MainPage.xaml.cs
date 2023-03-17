using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace module03_activity
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Activity01(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new activity1());
        }

        private async void Activity02(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new activity2());
        }
        private async void Activity03(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new activity3());
        }

        private async void Activity04(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new activity4());
        }
    }
}
