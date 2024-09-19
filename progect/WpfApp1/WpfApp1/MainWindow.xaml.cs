using Microsoft.Win32;
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
namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int a = Convert.ToInt32(inputWay.Text);

            int perimetr = a + a + a + a;
            int Sqare = a * a;

            OutputPerimetr.Text = Convert.ToString($"Периметр квадрата равен {perimetr}");
            OutputSqare.Text = Convert.ToString($"Площадь квадрата равна {Sqare}");

        }

        private void Imagebutton(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();

            if(openFile.ShowDialog() == true)
            {
                BitmapImage bitmap = new BitmapImage(new Uri(openFile.FileName));

               img1.Source = bitmap;
            }

            
        }
    }
}
