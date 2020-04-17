using System;
using System.Linq;
using System.Threading.Tasks;
using Tidez.Views;
using Xamarin.Forms;

namespace Tidez
{
    public partial class UserSummaryPage : ContentPage
    {
        private Core.TideData.Location location;
        public UserSummaryPage()
        {
            InitializeComponent();
            startDatePicker.Date = DateTime.Now;
            //picker.SelectedIndex = 0;
            picker.SelectedItem = UIConstants.NumberOfLocationOptions[0];
        }

        
        async void OnNavigationInvoked(object sender, EventArgs e)
        {
            DoUpdate();
            //await Navigation.PushAsync(new UserDetailsPage());
        }

        async void OnThemeToolbarItemClicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new LocationsPage()));
            //await Navigation.PushModalAsync(new NavigationPage(new ThemeSelectionPage()));
        }

        private void OnPickerSelectionChanged(object sender, EventArgs e)
        {
            DoUpdate();
        }

        private void startDatePicker_DateSelected(object sender, DateChangedEventArgs e)
        {
            DoUpdate();
        }

        private async void DoUpdate()
        {
            var now = startDatePicker.Date;
            LocationData locationData = picker.SelectedItem as LocationData;
            location = Core.TideData.GetLocationId(locationData.Description);
            Task<Core.DailyData> loadTask = Core.TideData.LoadTideData(now, location);
            var results = await loadTask;
            highTide1.Text = GetTideText(results.FirstHighTide, results);
            highTide2.Text = GetTideText(results.SecondHighTide, results);
            lowTide1.Text = GetTideText(results.FirstLowTide, results);
            lowTide2.Text = GetTideText(results.SecondLowTide, results);
            sunRise.Text = results.SunRise.Value.ToShortTimeString();
            sunSet.Text = results.SunSet.Value.ToShortTimeString();

        }

        private static string GetTideText(DateTime? time, Core.DailyData data)
        {
            if (!time.HasValue)
                return string.Empty;

            var str = time.Value.ToShortTimeString();

            if (data.Date.Date == DateTime.Now.Date && data.Times.Any())
            {
                var nextTime = data.Times.Where(x => x.HasValue && x.Value > DateTime.Now).OrderBy(x => x.Value).FirstOrDefault();
                if (nextTime == time)
                {
                    str = $"* {str} *";
                }
            }

            return str;
        }
    }
}
