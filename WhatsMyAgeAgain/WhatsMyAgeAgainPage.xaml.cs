using Xamarin.Forms;
using System;


namespace WhatsMyAgeAgain
{
    public partial class WhatsMyAgeAgainPage : ContentPage
    {
        void Handle_Clicked(object sender, System.EventArgs e)
        {
            var month = int.Parse(MonthEntry.Text);
            var day = int.Parse(DayEntry.Text);
            var year = int.Parse(YearEntry.Text);

            var birthDate = new DateTime(year, month, day);
            var age = DateTime.Now.Date.Subtract(birthDate);

            var yearsAlive = age.Days / 365;

            OutputLabel.Text = yearsAlive.ToString();
            
        }

        public WhatsMyAgeAgainPage()
        {
            InitializeComponent();
        }
    }
}
