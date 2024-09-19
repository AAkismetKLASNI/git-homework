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

namespace WpfApp16
{
  
        public partial class MainWindow : Window
        {
            private int num1, num2, num3;
            private int sum, product;
            private bool showSum = true;

            public MainWindow()
            {
                InitializeComponent();
            }

            private void Button_Click(object sender, RoutedEventArgs e)
            {

                showSum = !showSum;

                if (showSum)
                {
                    ResultTextBlock.Text = $"Сумма: {sum}";
                }
                else
                {
                    ResultTextBlock.Text = $"Произведение: {product}";
                }
            }

            private void InputTextBox_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
            {
                if (e.Key == System.Windows.Input.Key.Enter)
                {

                    try
                    {

                        num1 = int.Parse(Num1TextBox.Text);
                        num2 = int.Parse(Num2TextBox.Text);
                        num3 = int.Parse(Num3TextBox.Text);


                        sum = num1 + num2 + num3;
                        product = num1 * num2 * num3;

                        ResultTextBlock.Text = $"Сумма: {sum}";
                    }
                    catch (Exception ex)
                    {
                        
                        MessageBox.Show("Ошибка ввода! Введите целые числа.", "Ошибка");
                    }
                }
            }
        private void Num1TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

            Calculate();
        }
        private void Num2TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

            Calculate();
        }
            private void Num3TextBox_TextChanged(object sender, TextChangedEventArgs e)
            {

                Calculate();
            }
            private void Calculate()
            {
                try
                {
                num1 = int.Parse(Num1TextBox.Text);
                num2 = int.Parse(Num2TextBox.Text);
                num3 = int.Parse(Num3TextBox.Text);

                sum = num1 + num2 + num3;
                product = num1 * num2 * num3;
                if (showSum)
                {
                    ResultTextBlock.Text = $"Сумма: {sum}";
                }
                else
                {
                    ResultTextBlock.Text = $"Произведение: {product}";
                }
            }
            catch(Exception ex)
            {
                ResultTextBlock.Text = "Ошибка ввода! Введите целые числа.";
            }
        }
    }
    }

private void Imagebutton(object sender, RoutedEventArgs e)
{
    OpenFileDialog openFile = new OpenFileDialog();

    if (openFile.ShowDialog() == true)
    {
        BitmapImage bitmap = new BitmapImage(new Uri(openFile.FileName));

        img1.Source = bitmap;
    }
