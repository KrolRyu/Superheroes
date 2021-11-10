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

namespace Superheroes
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int i = 0;
        public MainWindow()
        {
            InitializeComponent();

            

            comicDockPanel.DataContext = Superheroe.GetSamples()[i];

        }

        private void NextButton_Click(object sender, RoutedEventArgs e)
        {
            if (i < Superheroe.GetSamples().Count-1)
            {
                i++;
                comicDockPanel.DataContext = Superheroe.GetSamples()[i];
            }
            textoTextBlock.Text = (i + 1).ToString();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            if (i > 0)
            {
                i--;
                comicDockPanel.DataContext = Superheroe.GetSamples()[i];
            }
            textoTextBlock.Text = (i + 1).ToString();
        }
    }
}
