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

namespace Face
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private void cmChange(object sender, RoutedEventArgs e)
        {
            Brush C;
            C = Face1.Color;
            Face1.Color = Face2.Color;
            Face2.Color = C;
        }

        TFaceL Face1; 
        TFaceR Face2; 

        public MainWindow()
        {
            InitializeComponent();

            Face1 = new TFaceL(g1); // создаем объект
            Face2 = new TFaceR(g2); // создаем другой объект

            Face1.SetColor(Brushes.Blue);
            Face2.SetColor(Brushes.Red);
        }
    }
}
