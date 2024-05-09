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

namespace Курсовой_2._0.результаты_тестов
{
    /// <summary>
    /// Логика взаимодействия для темперамент.xaml
    /// </summary>
    public partial class темперамент : Page
    {
        public темперамент()
        {
            InitializeComponent();
            BallForTemperament.CheckTemperament();
            res1.Text = $"Ваш тип темперамента - это {BallForTemperament.TypeTemp} ({BallForTemperament.HightPercent}%)";
            res2.Text = BallForTemperament.HightPercentTemp;
            res3.Text = $"Флегматик - {BallForTemperament.percent1}%  Меланхолик - {BallForTemperament.percent2}%  Холерик - {BallForTemperament.percent3}%  Сангвиник - {BallForTemperament.percent4}%";
        }
    }
}
