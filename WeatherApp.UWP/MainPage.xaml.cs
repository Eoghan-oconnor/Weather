using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;


namespace WeatherApp.UWP
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private async void GetWeatherButton_Click(object sender, RoutedEventArgs e)
        {
            if (!String.IsNullOrEmpty(nameEntry.Text))
            {
                Weather weather = await WeatherServices.GetWeather(nameEntry.Text);
                locationText.Text = weather.Title;
                tempText.Text = weather.Temperature;
                windText.Text = weather.Wind;
                visibilityText.Text = weather.Visibility;
                humidityText.Text = weather.Humidity;
                sunriseText.Text = weather.Sunrise;
                sunsetText.Text = weather.Sunset;

                weatherBtn.Content = "Search Again";
            }
        }
    }
}
