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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace BillCalculator
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class GasPage : Page
    {
        public GasPage()
        {
            this.InitializeComponent();
        }
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            PreviousTextBox.Text = "0";
            CurrentTextBox.Text = "0";
            ConsumptionTextBlock.Text = "0";
            MonthsTextBox.Text = "1";
            AmountTextBlock.Text = "0";
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

        private void Calculate()
        {
            Gas.GetAmount(PreviousTextBox, CurrentTextBox, MonthsTextBox, ref ConsumptionTextBlock, ref AmountTextBlock);
        }

        private void PreviousTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            Calculate();
        }

        private void CurrentTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            Calculate();
        }

        private void MonthsTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            Calculate();
        }
        private async void RateAppBarButton_Click(object sender, RoutedEventArgs e)
        {
            await Preview.RateApp();
        }
    }
}
