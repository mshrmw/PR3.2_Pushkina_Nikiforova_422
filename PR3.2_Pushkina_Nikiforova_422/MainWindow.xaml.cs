using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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

namespace PR3._2_Pushkina_Nikiforova_422
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

        private void vichislit_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(op1.Text) || string.IsNullOrWhiteSpace(op2.Text))
            {
                MessageBox.Show("Введите оба операнда.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (!(plus.IsChecked == true || minus.IsChecked == true || umnog.IsChecked == true || del.IsChecked == true))
            {
                MessageBox.Show("Выберите операцию.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (!double.TryParse(op1.Text, out double operand1) || !double.TryParse(op2.Text, out double operand2))
            {
                MessageBox.Show("Введите корректные числовые значения.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            double result = 0;
            if (plus.IsChecked == true)
                result = operand1 + operand2;
            else if (minus.IsChecked == true)
                result = operand1 - operand2;
            else if (umnog.IsChecked == true)
                result = operand1 * operand2;
            else if (del.IsChecked == true)
            {
                if (operand2 == 0)
                {
                    MessageBox.Show("Деление на ноль невозможно.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
                result = operand1 / operand2;
            }

            res.Text = result.ToString();
        }
    }
}
