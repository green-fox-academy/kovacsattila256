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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            DrawHorizontal50(foxDraw);

            // Create a line drawing function that takes 2 parameters:
            // The x and y coordinates of the line's starting point
            // and draws a 50 long horizontal line from that point.
            // Draw 3 lines with that function. Use loop for that.
        }
        public static void DrawHorizontal50(FoxDraw foxDraw)
        {
            foxDraw.StrokeColor(Colors.Black);
            int[] x = { 300, 100, 900 };
            int[] y = { 100, 500, 200 };
            for (int i = 0; i < 3; i++)
            {
                var startPoint = new Point(x[i], y[i]);
                var endPoint = new Point(x[i]+50, y[i]);
                foxDraw.DrawLine(startPoint, endPoint);
            }
        }
    }
}