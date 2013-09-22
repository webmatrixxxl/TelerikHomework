using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Xaml.Shapes;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace GesturesAndrespondingToInteractions
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {

        RotateTransform rotation = new RotateTransform();
        private double colorAngle;
        private string color;

        public MainPage()
        {
            this.InitializeComponent();

            Palette.RenderTransform = rotation;
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.  The Parameter
        /// property is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }



        private void RotatingPaletteleManipulationDelta(object sender, ManipulationDeltaRoutedEventArgs e)
        {
            var palette = sender as Canvas;

            rotation.CenterX = palette.Width / 2;
            rotation.CenterY = palette.Height / 2;
            rotation.Angle += e.Delta.Rotation;
            colorAngle = rotation.Angle;
        }


        private void Drow(object sender, TappedRoutedEventArgs e)
        {
            var canves = sender as Canvas;

         

            if (colorAngle > 20 && colorAngle < 70)
            {
                color = "Red";
            }
            else if (colorAngle > 90 && colorAngle < 150)
            {
                color = "Green";
            }
            else if (colorAngle > 200 && colorAngle < 260)
            {
                color = "Black";
            }
            else if (colorAngle > 290 && colorAngle < 340)
            {
                color = "Blue";
            }


    

            s.Fill = new SolidColorBrush(Colors.Black);
           
        }
    }
}
