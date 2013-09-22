using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
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

namespace Asynchronous_Programing_Homework
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private async void CalculatePrimesClick(object sender, RoutedEventArgs e)
        {
            var start = int.Parse(beginingRange.Text);
            var end = int.Parse(endRange.Text);
            TextBlock prime = Primes;
            bool Switch = primeSwitch.IsOn;
            var result = await PrimesCalculator.GetPrimesInRangeAsync(start, end, Switch);
            prime.Text = result;
        }

        private async void CalculatePrimesClick2(object sender, RoutedEventArgs e)
        {
            var start = int.Parse(beginingRange2.Text);
            var end = int.Parse(endRange2.Text);
            TextBlock prime = Primes2;
            bool Switch = primeSwitch2.IsOn;
            var result = await PrimesCalculator.GetPrimesInRangeAsync(start, end, Switch);
            prime.Text = result;
        }

        private async void CalculatePrimesClick3(object sender, RoutedEventArgs e)
        {
            var start = int.Parse(beginingRange3.Text);
            var end = int.Parse(endRange3.Text);
            TextBlock prime = Primes3;
            bool Switch = primeSwitch3.IsOn;
            var result = await PrimesCalculator.GetPrimesInRangeAsync(start, end, Switch);
            prime.Text = result;
        }
    }
}