using BillCalculator.Models;
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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace BillCalculator
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void ElectrictyAppBarButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(ElectricityTips));
        }

        private void GasAppBarButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(GasTips));
        }

        private void WaterAppBarButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(WaterTips));
        }

        private void AboutAppBarButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(About));
        }

        private void ElectricityButton_Click(object sender, RoutedEventArgs e)
        {

            Frame.Navigate(typeof(ElectricityPage));
        }

        private void GasButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(GasPage));
        }

        private void WaterButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(WaterPage));
        }

        private async void RateAppBarButton_Click(object sender, RoutedEventArgs e)
        {
            await Preview.RateApp();
        }
    }
}
