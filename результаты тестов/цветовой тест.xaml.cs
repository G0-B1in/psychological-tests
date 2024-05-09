using System.Windows.Controls;

namespace Курсовой_2._0.результаты_тестов
{
    /// <summary>
    /// Логика взаимодействия для цветовой_тест.xaml
    /// </summary>
    public partial class цветовой_тест : Page
    {
        public цветовой_тест()
        {
            InitializeComponent();
            res1.Text = Colors.res1();
            res2.Text = Colors.res2();
            res3.Text = Colors.res3();
            res4.Text = Colors.res4();
            res5.Text = Colors.res5();
            res6.Text = Colors.res6();
            res7.Text = Colors.res7();
            res8.Text = Colors.res8();
        }

    }
}


