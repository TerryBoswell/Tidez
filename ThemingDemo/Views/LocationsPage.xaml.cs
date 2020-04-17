using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tidez.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LocationsPage : ContentPage
    {
        public LocationsPage()
        {
            InitializeComponent();
        }
        void OnPickerSelectionChanged(object sender, EventArgs e)
        {
        }
            //void OnPickerSelectedIndexChanged(object sender, EventArgs e)
            //{
            //    var picker = (Picker)sender;
            //    int selectedIndex = picker.SelectedIndex;

            //    if (selectedIndex != -1)
            //    {
            //        //do somthing here
            //        //(string)picker.ItemsSource[selectedIndex];
            //    }
            //}
        }
}