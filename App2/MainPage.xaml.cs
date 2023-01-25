using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App2
{
    public interface IBaseUrl { string Get(); }
    [XamlCompilation(XamlCompilationOptions.Compile)]

    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();

            var urlSource = new UrlWebViewSource();

            string baseUrl = DependencyService.Get<IBaseUrl>().Get();
            string filePathUrl = Path.Combine(baseUrl, "index.html");
            urlSource.Url = filePathUrl;
            webView.Source = urlSource;
        }
        /*private void _button_Clicked(object sender, EventArgs e)
        {
            webView.Source = "https://xamarin.swappsdev.net/";
        }*/
    }
}
