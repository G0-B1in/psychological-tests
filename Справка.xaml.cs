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
    /// Логика взаимодействия для Справка.xaml
    /// </summary>
    public partial class Справка : Window
    {
        public Справка()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Закрывает справку
        /// </summary>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
