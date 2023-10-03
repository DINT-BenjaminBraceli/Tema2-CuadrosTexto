using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Tema2_CuadrosTexto
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void pressTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if ((sender as TextBox).Tag.Equals("nombre"))
            {
                if (e.Key == Key.F1)
                {
                    if (nombreTextBlock.Visibility == Visibility.Visible)
                    {
                        nombreTextBlock.Visibility = Visibility.Hidden;
                    }
                    else
                    {
                        nombreTextBlock.Visibility = Visibility.Visible;
                    }
                }
            }
            else if ((sender as TextBox).Tag.Equals("apellido"))
            {
                if (e.Key == Key.F1)
                {
                    if (apellidoTextBlock.Visibility == Visibility.Visible)
                    {
                        apellidoTextBlock.Visibility = Visibility.Hidden;
                    }
                    else
                    {
                        apellidoTextBlock.Visibility = Visibility.Visible;
                    }
                }
            }
            else if ((sender as TextBox).Tag.Equals("edad"))
            {
                if (e.Key == Key.F2 && !int.TryParse(edadTextBox.Text, out int i))
                {
                    edadTextBlock.Visibility = Visibility.Visible;
                }
                else if (e.Key == Key.F2 && int.TryParse(edadTextBox.Text, out int j))
                {
                    edadTextBlock.Visibility = Visibility.Hidden;
                }

            }
        }
    }
}
