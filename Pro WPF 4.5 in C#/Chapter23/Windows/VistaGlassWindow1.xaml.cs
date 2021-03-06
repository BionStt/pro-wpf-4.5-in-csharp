using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Interop;

namespace Windows
{
    /// <summary>
    /// Interaction logic for VistaGlassWindow.xaml
    /// </summary>

    public partial class VistaGlassWindow1 : System.Windows.Window
    {

        public VistaGlassWindow1()
        {
            InitializeComponent();
        }


        private void OnLoaded(object sender, RoutedEventArgs e)
        {

            try
            {
                VistaGlassHelper.ExtendGlass(this, -1, -1, -1, -1);
                
            }
            // If not Vista, paint background white.
            catch //(DllNotFoundException)
            {
                this.Background = Brushes.White;
            }
        }


    }
}