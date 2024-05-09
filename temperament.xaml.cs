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
    /// Логика взаимодействия для temperament.xaml
    /// </summary>
    public partial class temperament : Window
    {
        public temperament()
        {
            InitializeComponent();
        }        

        /// <summary>
        /// списки для начисления баллов 
        /// </summary>
        public List<char> allCount = new List<char>();
        public List<char> T1Count = new List<char>();
        public List<char> T2Count = new List<char>();
        public List<char> T3Count = new List<char>();
        public List<char> T4Count = new List<char>();

        /// <summary>
        /// массивы с вопросами
        /// </summary>
        string[] temp1 = new string[] { "Вы спокойны и хладнокровны?", "Вы последовательны, обстоятельны в делах?", "Вы осторожны и рассудительны?", "Вы умеете ждать?", "Вы молчаливы и не любите попусту болтать?", "Вы сдержанны и терпеливы?", "Вы обладаете спокойной, равномерной речью, с остановками, без выраженных эмоций?", "Вы доводите начатое дело до конца?", "Вы не растрачиваете попусту сил?", "Вы строго придерживаетесь выработанного распорядка жизни, системы в работе?", "Вы легко сдерживаете порывы?", "Вы маловосприимчивы к одобрению и порицанию?", "Вы не проявляете снисходительное отношение к колкостям в свой адрес.", "Вы постоянны в своих интересах?", "Вы ровны в отношениях со всеми?", "Вы инертны, малоподвижны, вялы?", "Вы любите аккуратность и порядок во всем?", "Вы с трудом приспосабливаетесь к новой обстановке.", "Вы обладаете выдержкой?" };
        string[] temp2 = new string[] { "Вы стеснительны, застенчивы?", "Вы теряетесь в новой обстановке?", "Вы не верите в свои силы?", "Вы затрудняетесь установить контакт с незнакомыми людьми?", "Вы легко переносите одиночество?", "Вы чувствуете подавленность и растерянность при неудачах?", "Вы склонны уходить в себя?", "Вы выстро утомляетесь?", "Вы обладаете слабой тихой речью?", "Вы невольно приспосабливаетесь к характеру собеседника.", "Вы впечатлительны до слезливости?", "Вы чрезвычайно восприимчивы к одобрению и порицанию?", "Вы предъявляете высокие требования к себе и к окружающим?", "Вы склонны к подозрительности, мнительности?", "Вы болезненно чувствительности и легко ранимы?", "Вы чрезмерно обидчивы.", "Вы скрытны и необщительны, не делитесь ни с кем своими мыслями.", "Вы малоактивны и робки?", "Вы безропотно покорны?", "Вы стремитесь вызвать сочувствие и помощь у окружающих?" };
        string[] temp3 = new string[] { "Вы неустойчивы, суетливы?", "Вы невыдержанны, вспыльчивы?", "Вы нетерпеливы?", "Вы резки и прямолинейны в отношениях с людьми?", "Вы решительны и инициативны?", "Вы упрямы?", "Вы находчивы в споре?", "Вы работаете рывками?", "Вы склонны к риску?", "Вы незлопамятны и необидчивы?", "Вы обладаете быстрой, страстной, со сбивчивыми патологиями речью?", "Вы неуравновешенны, склонны к горячности?", "Вы агрессивный забияка?", "Вы нетерпеливы к недостаткам?", "Вы обладаете выразительной речью?", "Вы способны быстро действовать и решать?", "Вы неустанно стремитесь к новому?", "Вы обладаете резкими, порывистыми движениями?", "Вы настойчивы в достижении поставленной цели?", "Вы склонны к резким сменам настроения?" };
        string[] temp4 = new string[] { "Вы веселы и жизнерадостны?", "Вы энергичны и деловиты?", "Вы часто не доводите начатое дело до конца?", "Вы склонны переоценивать себя?", "Вы способны быстро схватить новое?", "Вы неустойчивы в интересах и склонностях?", "Вы легко переживаете неудачи и неприятности?", "Вы легко приспосабливаетесь к разным обстоятельствам?", "Вы с увлечением беретесь за любое дело?", "Вы быстро остываете, если дело перестает вас интересовать?", "Вы быстро включаетесь в новую работу и быстро переключаетесь с одной работы на другую?", "Вы тяготитесь однообразной, будничной, кропотливой работой?", "Вы общительны и отзывчивы, не чувствуете скованности с новыми для вас людьми?", "Вы выносливы и работоспособны?", "Вы быстро засыпаете и пробуждаетесь?", "Вы обладаете громкой, быстрой, отчетливой речью, сопровождающейся живыми жестами, выразительной мимикой?", "Вы сохраняете самообладание в неожиданной, сложной обстановке?", "Вы всегда в бодром настроении?", "Вы часто несобранны, проявляете поспешность в решениях?", "Вы склонны иногда скользить по поверхности, отвлекаться?" };

        /// <summary>
        /// перенос баллов в банк данных
        /// </summary>
        public void Count()
        {
            int a = 0;
            int a1 = 0;
            int a2 = 0;
            int a3 = 0;
            int a4 = 0;
            for (int i = 0; i < allCount.Count; i++)
            {
                if (allCount[i] == '+') a++;
            }
            for (int i = 0; i < T1Count.Count; i++)
            {
                if (T1Count[i] == '+') a1++;
            }

            for (int i = 0; i < T2Count.Count; i++)
            {
                if (T2Count[i] == '+') a2++;
            }

            for (int i = 0; i < T3Count.Count; i++)
            {
                if (T3Count[i] == '+') a3++;
            }

            for (int i = 0; i < T4Count.Count; i++)
            {
                if (T4Count[i] == '+') a4++;
            }

            BallForTemperament.allCount = a;
            BallForTemperament.T1Count = a1;
            BallForTemperament.T2Count = a2;
            BallForTemperament.T3Count = a3;
            BallForTemperament.T4Count = a4;
        }

        /// <summary>
        /// возврат на вопрос назад
        /// </summary>
        private void back_Click(object sender, RoutedEventArgs e)
        {
            BallForTemperament.page--;

            if (BallForTemperament.page < 0) /// переход на главное окно
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
            else
            {
                int a = allCount.Count;
                allCount.RemoveAt(a - 1);
                if (BallForTemperament.page < 19)
                {
                    tb2.Text = temp1[BallForTemperament.page]; /// обновляет текст вопроса
                    int b = T1Count.Count;
                    T1Count.RemoveAt(b - 1);
                }
                else
                {
                    if (BallForTemperament.page < 39)
                    {
                        tb2.Text = temp2[BallForTemperament.page - 19];
                        int b = T2Count.Count;
                        T2Count.RemoveAt(b - 1);
                    }
                    else
                    {
                        if (BallForTemperament.page < 59)
                        {
                            tb2.Text = temp3[BallForTemperament.page - 39];
                            int b = T3Count.Count;
                            T3Count.RemoveAt(b - 1);
                        }
                        else
                        {
                            if (BallForTemperament.page < 79)
                            {
                                tb2.Text = temp4[BallForTemperament.page - 59];
                                int b = T4Count.Count;
                                T4Count.RemoveAt(b - 1);
                            }

                        }
                    }
                }

                // обновляет шкалу заполнения
                pb.Value = BallForTemperament.page + 1;
                tb1.Text = $"Вопрос {BallForTemperament.page + 1} из 79"; 
                Count();
            }
        }

        /// <summary>
        ///  записывает значение "-" в спски 
        /// </summary>
        private void no_Click(object sender, RoutedEventArgs e)
        {
            BallForTemperament.page++;
            allCount.Add('-');
            if (BallForTemperament.page < 19)
            {
                tb2.Text = temp1[BallForTemperament.page];
                T1Count.Add('-');
            }
            else
            {
                if (BallForTemperament.page < 39)
                {
                    tb2.Text = temp2[BallForTemperament.page - 19];
                    T2Count.Add('-');

                }
                else
                {
                    if (BallForTemperament.page < 59)
                    {
                        tb2.Text = temp3[BallForTemperament.page - 39];
                        T3Count.Add('-');

                    }
                    else
                    {
                        if (BallForTemperament.page < 79)
                        {
                            tb2.Text = temp4[BallForTemperament.page - 59];
                            T4Count.Add('-');

                        }
                        else
                        {
                            /// открытие окна с результатами
                            results w = new results();
                            w.fram.NavigationService.Navigate(new результаты_тестов.темперамент());
                            w.Show();
                            w.WindowState = this.WindowState;
                            this.Close();

                        }
                    }
                }
            }

            pb.Value = BallForTemperament.page + 1;
            tb1.Text = $"Вопрос {BallForTemperament.page + 1} из 79";
            Count();

        }

        /// <summary>
        ///  записывает значение "+" в спски 
        /// </summary>
        private void yes_Click(object sender, RoutedEventArgs e)
        {
            BallForTemperament.page++;
            allCount.Add('+');
            if (BallForTemperament.page < 19)
            {
                tb2.Text = temp1[BallForTemperament.page];
                T1Count.Add('+');
            }
            else
            {
                if (BallForTemperament.page < 39)
                {
                    tb2.Text = temp2[BallForTemperament.page - 19];
                    T2Count.Add('+');
                }
                else
                {
                    if (BallForTemperament.page < 59)
                    {
                        tb2.Text = temp3[BallForTemperament.page - 39];
                        T3Count.Add('+');
                    }
                    else
                    {
                        if (BallForTemperament.page < 79)
                        {
                            tb2.Text = temp4[BallForTemperament.page - 59];
                            T4Count.Add('+');
                        }
                        else
                        {
                           
                            results w = new results();
                            w.Show();
                            w.fram.NavigationService.Navigate(new результаты_тестов.темперамент());
                            w.WindowState = this.WindowState;
                            this.Close();


                        }
                    }
                }
            }


            pb.Value = BallForTemperament.page + 1;
            tb1.Text = $"Вопрос {BallForTemperament.page + 1} из 79";
            Count();
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
