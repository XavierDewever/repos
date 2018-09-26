using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XrnCourse.FormsHelloSap
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            lblWelcome.Text = "Hello, ";

            #if __IOS__ //IOS specific code
             lblWelcome.Text += "IOS!";
            #elif __ANDROID__ //Android specific code
             lblWelcome.Text += "Android!";
            #elif WINDOWS_UWP //Universal Windows Platform specific code
                        lblWelcome.Text += "UWP!";
            #elif WINDOWS_APP //Windows 8.1 specific code
             lblWelcome.Text += "Windows 8.1!";
            #elif WINDOWS__PHONE_APP //Windows Phone 8.1 specific code
             lblWelcome.Text += "Windows 8.1 Phone!";
            #else
             lblWelcome.Text += "unknown platform!";
            #endif
        }
    }
}
