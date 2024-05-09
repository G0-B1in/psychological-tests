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

namespace Курсовой_2._0
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

        /// <summary>
        /// переход на окно с правилами цветового теста
        /// </summary>
        private void Button_Test_3(object sender, RoutedEventArgs e)
        {
            Rules w = new Rules();
            w.Show();
            Rules.test = 3;
            w.fram.NavigationService.Navigate(new правила_тесотв.цветовой_тест());
            w.WindowState = this.WindowState;
            this.Close();
        }

        /// <summary>
        /// переход на окно с правилами рисуночного теста
        /// </summary>
        private void Button_Test_2(object sender, RoutedEventArgs e)
        {
            Rules w = new Rules();
            w.Show();
            Rules.test = 2;
            w.fram.NavigationService.Navigate(new правила_тесотв.рисуночный_тест());
            w.WindowState = this.WindowState;
            this.Close();
        }

        /// <summary>
        /// переход на окно с правилами теста на темперамент
        /// </summary>
        private void Button_Test_1(object sender, RoutedEventArgs e)
        {
            Rules w = new Rules();
            w.Show();
            Rules.test = 1;
            w.fram.NavigationService.Navigate(new правила_тесотв.темперамент());
            w.WindowState = this.WindowState;
            this.Close();
        }

        /// <summary>
        /// открывает справку
        /// </summary>
        private void Button_Reference(object sender, RoutedEventArgs e)
        {
            Справка w = new Справка();
            w.ShowDialog();
        }

        /// <summary>
        /// открыть справку на клавишу F1
        /// </summary>
        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.F1)
            {
                
                Справка w = new Справка();
                w.ShowDialog();
                 
            }
        }
    }
}
