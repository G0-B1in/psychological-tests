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
using System.Windows.Shapes;

namespace Курсовой_2._0
{
    /// <summary>
    /// Логика взаимодействия для drawing.xaml
    /// </summary>
    public partial class drawing : Window
    {
        public drawing()
        {
            InitializeComponent();
            fram.NavigationService.Navigate(new рисуночный_тест.вопрос1()); /// показывает первый вопрос теста
        }

        /// <summary>
        /// переход на окно главного меню
        /// </summary>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult m = MessageBox.Show("Вы точно хотите закончить тест?", "", MessageBoxButton.YesNo);
            if (m == MessageBoxResult.Yes)
            {
                MainWindow w = new MainWindow();
                w.Show();
                w.WindowState = this.WindowState;
                this.Close();
            }
               
        }

        /// <summary>
        /// открыть справку на клавишу F1
        /// </summary>
        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.F1)
            {
                Справка w = new Справка();
                w.ShowDialog();

            }
        }
    }
}
