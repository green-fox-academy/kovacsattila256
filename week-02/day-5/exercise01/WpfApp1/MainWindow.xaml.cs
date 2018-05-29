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
            DrawRays(foxDraw);

        }
        public static void DrawRays(FoxDraw foxDraw)
        {
            foxDraw.StrokeColor(Colors.Purple);

            for (int i = 0; i < 12; i++)
            {
                var startPoint = new Point(i * 50 + 50, 0);
                var endPoint = new Point(600, i * 50 + 50);
                foxDraw.DrawLine(startPoint, endPoint);
            }
            foxDraw.StrokeColor(Colors.Green);

            for (int i = 0; i < 12; i++)
            {
                var startPoint = new Point(0, i * 50 + 50);
                var endPoint = new Point(i * 50 + 50, 600);
                foxDraw.DrawLine(startPoint, endPoint);
            }
            /*
            Here we can see the crappy method but the 
            coordinates are informative:
            
            foxDraw.StrokeColor(Colors.Purple);
            foxDraw.DrawLine(0, 0, 700, 50);
            foxDraw.DrawLine(50, 0, 700, 100);
            foxDraw.DrawLine(100, 0, 700, 150);
            foxDraw.DrawLine(150, 0, 700, 200);
            foxDraw.DrawLine(200, 0, 700, 250);
            foxDraw.DrawLine(250, 0, 700, 300);
            foxDraw.DrawLine(300, 0, 700, 350);
            foxDraw.DrawLine(350, 0, 700, 400);
            foxDraw.DrawLine(400, 0, 700, 450);
            foxDraw.DrawLine(450, 0, 700, 500);
            foxDraw.DrawLine(500, 0, 700, 550);
            foxDraw.DrawLine(550, 0, 700, 600);
            foxDraw.DrawLine(600, 0, 700, 650);
            foxDraw.DrawLine(650, 0, 700, 700);

            foxDraw.StrokeColor(Colors.Green);
            foxDraw.DrawLine(0, 50, 50, 700);
            foxDraw.DrawLine(0, 100, 100, 700);
            foxDraw.DrawLine(0, 150, 150, 700);
            foxDraw.DrawLine(0, 200, 200, 700);
            foxDraw.DrawLine(0, 250, 250, 700);
            foxDraw.DrawLine(0, 300, 300, 700);
            foxDraw.DrawLine(0, 350, 350, 700);
            foxDraw.DrawLine(0, 400, 400, 700);
            foxDraw.DrawLine(0, 450, 450, 700);
            foxDraw.DrawLine(0, 500, 500, 700);
            foxDraw.DrawLine(0, 550, 550, 700);
            foxDraw.DrawLine(0, 600, 600, 700);
            foxDraw.DrawLine(0, 650, 650, 700);
            foxDraw.DrawLine(0, 700, 700, 700);
            */
        }
    }
}