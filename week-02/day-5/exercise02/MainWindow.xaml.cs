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
using GreenFox_FoxDraw2;


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
            DrawRays(foxDraw);

        }
        public static void DrawRays(FoxDraw foxDraw)
        {
            foxDraw.StrokeColor(Colors.Green);

            for (int i = 0; i < 12; i++)
            {
                var startPoint = new Point(i * 25 + 25, 300);
                var endPoint = new Point(300, i * 25 + 325);
                foxDraw.DrawLine(startPoint, endPoint);
            }
            for (int i = 0; i < 12; i++)
            {
                var startPoint = new Point(300, i * 25 + 25);
                var endPoint = new Point(275-i * 25, 300);
                foxDraw.DrawLine(startPoint, endPoint);
            }
            for (int i = 0; i < 12; i++)
            {
                var startPoint = new Point(300, i * 25 + 25);
                var endPoint = new Point(325 + i * 25, 300);
                foxDraw.DrawLine(startPoint, endPoint);
            }

        }
    }
}
// not yet ready!