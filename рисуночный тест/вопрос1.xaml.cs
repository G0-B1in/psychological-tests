using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Курсовой_2._0.рисуночный_тест
{
    /// <summary>
    /// Логика взаимодействия для вопрос1.xaml
    /// </summary>
    public partial class вопрос1 : Page
    {
        
        bool isDrawing = false; //обозначение начала рисования

        public вопрос1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Начало рисования при зажатии ЛКМ
        /// </summary>
        private void DrawingMouseDown(object sender, MouseButtonEventArgs e)
        {
            Mouse.Capture(DrawingTarget);
            isDrawing = true;
            StartFigure(e.GetPosition(DrawingTarget));
        }

        /// <summary>
        /// Конец рисования при отпускании ЛКМ
        /// </summary>
        private void DrawingMouseUp(object sender, MouseButtonEventArgs e)
        {
            AddFigurePoint(e.GetPosition(DrawingTarget));
            EndFigure();
            isDrawing = false;
            Mouse.Capture(null);
        }

        /// <summary>
        /// Линия следует за курсором
        /// </summary>
        private void DrawingMouseMove(object sender, MouseEventArgs e)
        {
            if (!isDrawing)
                return;
            AddFigurePoint(e.GetPosition(DrawingTarget));
        }



        PathFigure currentFigure;

        /// <summary>
        /// Начальная точка фигуры
        /// </summary>
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

        /// <summary>
        /// Продолжение фигуры
        /// </summary>
        void AddFigurePoint(Point point)
        {
            currentFigure.Segments.Add(new LineSegment(point, isStroked: true));
        }

        /// <summary>
        /// Конец фигуры
        /// </summary>
        void EndFigure()
        {
            currentFigure = null;
        }


        /// <summary>
        /// Переход на следующий вопрос
        /// </summary>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (DrawingTarget.Children.Count <= 1) throw new Exception("Нарисуйте что-нибудь");
                if (tb.Text == "") throw new Exception("Введите прилагательные");

                // конвертирование содержимого полотна в рисунок
                RenderTargetBitmap bmp = new RenderTargetBitmap((int)DrawingTarget.ActualWidth, (int)DrawingTarget.ActualHeight, 96d, 96d, PixelFormats.Pbgra32);
                DrawingTarget.Measure(new Size((int)DrawingTarget.ActualWidth, (int)DrawingTarget.ActualHeight));
                DrawingTarget.Arrange(new Rect(new Size((int)DrawingTarget.ActualWidth, (int)DrawingTarget.ActualHeight)));
                bmp.Render(DrawingTarget);

                рисуночный_тест.вопрос2 w = new рисуночный_тест.вопрос2();
                NavigationService.Navigate(w);
                w.im1.Source = bmp;
                w.t1.Text = tb.Text;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Стерает все нарисованые линии
        /// </summary>
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Ellipse ELIPS = el;
            DrawingTarget.Children.Clear();

            DrawingTarget.Children.Add(ELIPS);


        }


    }
}
