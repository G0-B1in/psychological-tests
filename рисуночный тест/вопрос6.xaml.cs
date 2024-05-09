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

namespace Курсовой_2._0.рисуночный_тест
{
    /// <summary>
    /// Логика взаимодействия для вопрос6.xaml
    /// </summary>
    public partial class вопрос6 : Page
    {
        bool isDrawing = false;

        public вопрос6()
        {
            InitializeComponent();
        }
        private void DrawingMouseDown(object sender, MouseButtonEventArgs e)
        {
            Mouse.Capture(DrawingTarget);
            isDrawing = true;
            StartFigure(e.GetPosition(DrawingTarget));
        }

        private void DrawingMouseUp(object sender, MouseButtonEventArgs e)
        {
            AddFigurePoint(e.GetPosition(DrawingTarget));
            EndFigure();
            isDrawing = false;
            Mouse.Capture(null);
        }

        private void DrawingMouseMove(object sender, MouseEventArgs e)
        {
            if (!isDrawing)
                return;
            AddFigurePoint(e.GetPosition(DrawingTarget));
        }

        PathFigure currentFigure;

        void StartFigure(Point start)
        {
            currentFigure = new PathFigure() { StartPoint = start };
            var currentPath =
                new System.Windows.Shapes.Path()
                {
                    Stroke = Brushes.Black,
                    StrokeThickness = 3,
                    Data = new PathGeometry() { Figures = { currentFigure } }
                };
            DrawingTarget.Children.Add(currentPath);
        }

        void AddFigurePoint(Point point)
        {
            currentFigure.Segments.Add(new LineSegment(point, isStroked: true));
        }

        void EndFigure()
        {
            currentFigure = null;
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (DrawingTarget.Children.Count <= 1) throw new Exception("Нарисуйте что-нибудь");
                if (tb.Text == "") throw new Exception("Введите прилагательные");


                RenderTargetBitmap bmp = new RenderTargetBitmap((int)DrawingTarget.ActualWidth, (int)DrawingTarget.ActualHeight, 96d, 96d, PixelFormats.Pbgra32);
                DrawingTarget.Measure(new Size((int)DrawingTarget.ActualWidth, (int)DrawingTarget.ActualHeight));
                DrawingTarget.Arrange(new Rect(new Size((int)DrawingTarget.ActualWidth, (int)DrawingTarget.ActualHeight)));
                bmp.Render(DrawingTarget);

                результаты_тестов.рисуночный_тест w = new результаты_тестов.рисуночный_тест();
                NavigationService.Navigate(w);
                w.img6.Source = bmp;
                w.img1.Source = im1.Source;
                w.img2.Source = im2.Source;
                w.img3.Source = im3.Source;
                w.img4.Source = im4.Source;
                w.img5.Source = im5.Source;
                w.tb6.Text = tb.Text;
                w.tb1.Text = t1.Text;
                w.tb2.Text = t2.Text;
                w.tb3.Text = t3.Text;
                w.tb4.Text = t4.Text;
                w.tb5.Text = t5.Text;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Path path1 = p1;
            Path path2 = p2;
            DrawingTarget.Children.Clear();
            DrawingTarget.Children.Add(path1);
            DrawingTarget.Children.Add(path2);


        }

    }
}
