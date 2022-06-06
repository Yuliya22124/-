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

namespace Кабанова
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
            // описываем переменные
            double a, b, c;
            // пытаемся преобразовать строку из TextBox.Text в целое число
            bool result1 = double.TryParse(TextBox.Text, out a);
            if (result1 == false)
            // если возникла ошибка преобразования то 
            // выводим сообщение и заканчиваем работу метода
            {
                MessageBox.Show("Неверный формат числа " + TextBox.Text + "!");
                return; // заканчиваем работу метода
            }
            // пытаем преобразовать строку из textBox2.Text в целое число
            bool result2 = double.TryParse(TextBox1.Text, out b);
            if (result2 == false) // если возникла ли ошибка преобразования
            {                  // то выводим сообщение и заканчиваем работу метода
                MessageBox.Show("Неверный формат числа " + TextBox1.Text + "!");
                return; // заканчиваем работу метода
            }
            c = (3*Math.Sin(a)+6*Math.Cos(b))/2;
            string cStr = c.ToString();
            Label1.Content = cStr;
            return; // заканчиваем работу метода
        }
    }
}
