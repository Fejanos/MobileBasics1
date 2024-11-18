using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace MobileBasics1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void button1_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Your given content", entry1.Text, "close");
        }
    }
}
