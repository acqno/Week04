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

namespace UserControlDemo
{
    /// <summary>
    /// Interaction logic for CustomCtrl.xaml
    /// </summary>
    public partial class CustomCtrl : UserControl
    {

        public double[] points = new double[5];

        public CustomCtrl()
        {
            InitializeComponent();
        }

        // METHODS 

        public void SetData(double[] array)
        {

            for (int i = 0; i < array.Length; i++)
            {
                points[i] = array[i];
            }
        }

        protected override void OnRender(DrawingContext context)
        {
            base.OnRender(context);
            /*
            // draw a rectangle
            Point topLeft = new Point(0, ActualHeight * .5);
            Point bottomRight = new Point(ActualWidth * .5, ActualHeight);
            Pen pen = new Pen(Brushes.LightBlue, 4);
            Brush brush = Brushes.Pink;

            Rect rec = new Rect(topLeft, bottomRight);

            context.DrawRectangle(null, new Pen(Brushes.Black, 0.5), new Rect(0, 0, ActualWidth, ActualHeight));
            context.DrawRectangle(brush, pen, rec);

            -
            //draw a circle right half
            Point center = new Point(ActualWidth * .75, ActualHeight * .5);
            Brush fancy = new RadialGradientBrush(Color.FromRgb(200, 50, 100), Color.FromRgb(50, 100, 200));

            context.DrawEllipse(fancy, null, center, ActualWidth * .25, ActualHeight * .5);
            */

            Point point1 = new Point(0, ActualHeight * .5);
            Point point2 = new Point(ActualWidth * 0.25, points[0]);
            Point point3 = new Point(ActualWidth * 0.5, points[1]);
            Point point4 = new Point(ActualWidth * 0.75, points[2]);
            Point point5 = new Point(ActualWidth, points[3]);

            context.DrawRectangle(Brushes.LightBlue, null, new Rect(point1, point2));

            //context.DrawLine(new Pen(Brushes.LightBlue, 4), point1, point2);
            /*context.DrawLine(new Pen(Brushes.LightBlue, 4), point2, point3);
            context.DrawLine(new Pen(Brushes.LightBlue, 4), point3, point4);
            context.DrawLine(new Pen(Brushes.LightBlue, 4), point4, point5);*/

        }
    }
}