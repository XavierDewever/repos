
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XrnCourse.FormsHello
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AlertPage : ContentPage
	{
		public AlertPage ()
		{
			InitializeComponent ();		
		}

		private async void btnPopupHello_Clicked(object sender, System.EventArgs e)
		{
			await DisplayAlert("Alert", "Hello there!", "Hi!");
		}
	}
}