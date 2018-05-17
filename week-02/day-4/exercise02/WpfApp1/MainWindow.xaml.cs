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
            // Draw a box that has different colored lines on each edge.

            foxDraw.StrokeColor(Colors.Red);
            foxDraw.DrawLine(200, 400, 200, 800);

            foxDraw.StrokeColor(Colors.Green);
            foxDraw.DrawLine(200, 800, 800, 800);

            foxDraw.StrokeColor(Colors.Blue);
            foxDraw.DrawLine(800, 800, 800, 400);

            foxDraw.StrokeColor(Colors.Black);
            foxDraw.DrawLine(200, 400, 800, 400);

        }
    }
}
