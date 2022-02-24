using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Essentials;

namespace Web_View_Application
{
    public partial class MainPage : ContentPage
    {
      
        public MainPage()
        {
            InitializeComponent();
            initialize();
        }

        void initialize()
        {
            date.Text = DateTime.Now.ToString();
        }
        void OnEntryCompleted(object sender, EventArgs args)
        {
            webView.Source = ((Entry)sender).Text;
        }
        void OnGoBackClicked(object sender, EventArgs args)
        {
            webView.GoBack();
        }
        void OnGoForwardClicked(object sender, EventArgs args)
        {
            webView.GoForward();
        }

        void onZajelButtonClicked(object sender, EventArgs args)
        {
            webView.Source = "https://zajel.najah.edu/";
        }

        void onGoogleButtonClicked(object sender, EventArgs args)
        {
            webView.Source = "https://google.com";
        }

 
    }
}
    
