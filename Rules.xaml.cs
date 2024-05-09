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
    /// Логика взаимодействия для Rules.xaml
    /// </summary>
    public partial class Rules : Window
    {
        public Rules()
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

        public static int test; //определяет тест

        /// <summary>
        /// вывод правил прохождения теста
        /// </summary>
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if(test == 3) // открывает цветовой тест
            {
                colors w = new colors();
                w.Show();
                w.WindowState = this.WindowState;
                // обнуляет значения в банке даных
                Colors.color1 = null;
                Colors.color2 = null;
                Colors.color3 = null;
                Colors.color4 = null;
                Colors.color5 = null;
                Colors.color6 = null;
                Colors.color7 = null;
                Colors.color8 = null;
            }

            if (test == 2) // открывает рисуночный тест
            {
                drawing w = new drawing();
                w.Show();
                w.WindowState = this.WindowState;
            }

            if (test == 1) // открывает тест на темперамент
            {
                temperament w = new temperament();
                w.Show();
                w.WindowState = this.WindowState;
                // обнуляет значения в банке даных
                BallForTemperament.T1Count = 0;
                BallForTemperament.T2Count = 0;
                BallForTemperament.T3Count = 0;
                BallForTemperament.T4Count = 0;
                BallForTemperament.allCount = 0;
                BallForTemperament.page = 0;
            }


            /// закрывает это окно
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
