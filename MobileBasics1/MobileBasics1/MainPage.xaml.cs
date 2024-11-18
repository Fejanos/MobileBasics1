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
        private FormModel Model = new FormModel();
        public MainPage()
        {
            InitializeComponent();
            this.BindingContext = Model;
        }

        private void PeopleList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            DisplayAlert("The selected Person", PeopleList.SelectedItem.ToString(), "Cancel");
        }
    }
}
