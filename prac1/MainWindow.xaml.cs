using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Lib_12;

namespace prac1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Метод инициализации элементов
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Выход из приложения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Вывод информации о разработчике и приложении
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInfo_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Демьяхин Роман ИСП-31 12 Вариант.\nНайти сумму n целых, случайных чисел, распределенных в диапазоне от 0 до n. \r\nВывести на экран на одной строке сгенерированные числа, на другой строке результат", "Информация");
        }
        /// <summary>
        /// Генерация случайных значений и вывод в TextBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGenerate_Click(object sender, RoutedEventArgs e)
        {
            int n;
            if (int.TryParse(tbNumbers.Text, out n))
            {
                tbRandom.Text = ClassSum.GenRandom(n.ToString());
            }
            else
            {
                MessageBox.Show("Введите корректное целое число.", "Ошибка ввода");
            }
        }
        /// <summary>
        /// Подсчет результата и вывод в TextBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCalc_Click(object sender, RoutedEventArgs e)
        {
            if (tbRandom.Text != "")
            {
                int sum = ClassSum.Summa(tbRandom.Text);
                tbRez.Text = sum.ToString();

            }
            else MessageBox.Show("Поле пустое", "Ошибка");
        }
    }
}