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
    /// Логика взаимодействия для results.xaml
    /// </summary>
    public partial class results : Window
    {
        public results()
        {
            InitializeComponent();
        }

        /// <summary>
        /// переход на главное меню
        /// </summary>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow w = new MainWindow();
            w.Show();
            w.WindowState = this.WindowState;
            this.Close();
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
