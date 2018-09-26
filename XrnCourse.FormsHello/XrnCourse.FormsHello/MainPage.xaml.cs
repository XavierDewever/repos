﻿using System;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XrnCourse.FormsHello
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            var msgService = DependencyService.Get<IMessageService>();
            lblWelcome.Text = "Hello, " + msgService.GetWelcomeMessage();
        }


        private async void btnAlertPage_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new AlertPage());
        }


        private async void btnActionSheet_Clicked(object sender, System.EventArgs e)
        {
            string action = await DisplayActionSheet("ActionSheet: What to do?",
                "Cancel", null, "Show me the time", "Tell a joke", "Wait 3 seconds");

            if (action == "Show me the time")
                await DisplayAlert("Time",
                    $"It's now {DateTime.Now.ToString("HH:mm")},Almost beer-o-clock!", "OK");

            else if (action == "Tell a joke")
                await DisplayAlert("Joke",
                                    $"Why is six afraid of seven?{Environment.NewLine}Because seven ate nine.",
                                    "LOL", "I don't get it");

            else if (action == "Wait 3 seconds")
            {
                await Task.Delay(3000);
                await DisplayAlert("Wait 3 seconds", "The wait is over", "OK");
            }





        }

    }
}
