using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Курсовой_2._0
{
    /// <summary>
    /// Логика взаимодействия для colors.xaml
    /// </summary>
    public partial class colors : Window
    {
        /// массивы для записи координат цветов
        double[] startPosX = new double[8];
        double[] startPosY = new double[8];

        public colors()
        {
            InitializeComponent();
            /// запись координат цветов в массивы
            for (int i = 0; i < startPosY.Length; i++)
                startPosY[i] = Canvas.GetTop(canvas1.Children[i]);

            for (int i = 0; i < startPosX.Length; i++)
                startPosX[i] = Canvas.GetLeft(canvas1.Children[i]);
        }

        /// <summary>
        /// возможность переноса цвета
        /// </summary>
        private void canvas1_Drop(object sender, DragEventArgs e)
        {
            if (e.Source is Canvas)
            {
                TextBlock src = e.Data.GetData(typeof(TextBlock))
                as TextBlock;
            }


        }

        /// <summary>
        /// выбор и перенос цвета зажатием левой клавиши мыши
        /// </summary>
        private void label1_MouseDown(object sender, MouseButtonEventArgs e)
        {
            var t = e.Source as TextBlock;
            if (t == null)
                return;
            if (e.ChangedButton == MouseButton.Left)
                if (DragDrop.DoDragDrop(t, t, DragDropEffects.All) ==
                DragDropEffects.Move)
                    t.Visibility = Visibility.Hidden;

            string s = "";
            for (int i = 0; i < 8; i++)
            {
                if (canvas1.Children[i].IsVisible)
                    return;
                s += (grid1.Children[0] as TextBox).Text;
            }
            if (s == "")
                return;
        }

        /// <summary>
        /// возможность переноса цвета
        /// </summary>
        private void canvas1_DragEnter(object sender, DragEventArgs e)
        {
            e.Handled = true;
            e.Effects = DragDropEffects.Move;
            var trg = e.Source as TextBlock;
            if (trg == null)
                return;

        }

        int a; //запоминает тег выбранного цвета

        /// <summary>
        /// поле принимает значения цвета
        /// </summary>
        private void grid1_Drop(object sender, DragEventArgs e)
        {

            var trg = e.Source as TextBox;
            if (trg == null)
                return;           
                var src = e.Data.GetData(typeof(TextBlock)) as TextBlock;
                trg.Text = src.Text;
                trg.Background = src.Background;
                trg.Foreground = src.Foreground;
                trg.Tag = src.Tag;
                a = int.Parse((string)src.Tag);
                src.Visibility = Visibility.Hidden;
                proverka.Visibility = Visibility.Visible;            
        }

        int b = 0; // определение количества выбранных цветов

        /// <summary>
        /// подтверждение выбора цвета
        /// </summary>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var tb = grid1.Children[0] as TextBox;
            if (Colors.color1 == null)
            {
                Colors.color1 = tb.Text;
                b++;
            }
            else
            {
                if (Colors.color2 == null)
                {
                    Colors.color2 = tb.Text;
                    b++;
                }
                else
                {
                    if (Colors.color3 == null)
                    {
                        Colors.color3 = tb.Text;
                        b++;
                    }
                    else
                    {
                        if (Colors.color4 == null)
                        {
                            Colors.color4 = tb.Text;
                            b++;
                        }
                        else
                        {
                            if (Colors.color5 == null)
                            {
                                Colors.color5 = tb.Text;
                                b++;
                            }
                            else
                            {
                                if (Colors.color6 == null)
                                {
                                    Colors.color6 = tb.Text;
                                    b++;
                                }
                                else
                                {
                                    if (Colors.color7 == null)
                                    {
                                        Colors.color7 = tb.Text;
                                        b++;
                                    }
                                    else
                                    {
                                        if (Colors.color8 == null)
                                        {
                                            Colors.color8 = tb.Text;
                                            b++;
                                        }
                                    }
                                }

                            }
                        }

                    }

                }
            }

            tb.Text = "";
            tb.Tag = "0";
            tb.Background = null;
            proverka.Visibility = Visibility.Hidden;


            if (b > 7)
            {
                // переход на окно с результатами 
                results w = new results();
                w.Show();
                w.WindowState = this.WindowState;
                this.Close();
                w.fram.NavigationService.Navigate(new результаты_тестов.цветовой_тест());
            }

            // меняет текст вопроса
            if (b > 0) question.Text = "Какой из оставшихся цветов вам кажется наиболее симпатичным?";

        }

        /// <summary>
        /// отмена выбора цвета
        /// </summary>
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var tb = grid1.Children[0] as TextBox;
            canvas1.Children[a - 1].Visibility = Visibility.Visible;
            tb.Text = "";
            tb.Tag = "0";
            tb.Background = null;
            proverka.Visibility = Visibility.Hidden;

        }

        /// <summary>
        /// переход на окно главного меню
        /// </summary>
        private void Button_Click_2(object sender, RoutedEventArgs e)
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
        /// предотвращение переноса цвета в поле, если там уже находится другой цвет 
        /// </summary>
        private void grid1_PreviewDragEnter(object sender, DragEventArgs e)
        {
            var trg = e.Source as TextBox;
            if (trg == null)
                return;
            e.Handled = true;
            e.Effects = trg.Text == "" ?
            DragDropEffects.Move : DragDropEffects.None;

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
