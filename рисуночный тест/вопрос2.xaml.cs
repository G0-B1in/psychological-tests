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
    /// Логика взаимодействия для вопрос2.xaml
    /// </summary>
    public partial class вопрос2 : Page
    {

        bool isDrawing = false;


        public вопрос2()
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

                рисуночный_тест.вопрос3 w = new рисуночный_тест.вопрос3();
                NavigationService.Navigate(w);
                w.im2.Source = bmp;
                w.im1.Source = im1.Source;
                w.t2.Text = tb.Text;
                w.t1.Text = t1.Text;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }




        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Polygon polygon = p;

            DrawingTarget.Children.Clear();
            DrawingTarget.Children.Add(polygon);


        }

    }
}
