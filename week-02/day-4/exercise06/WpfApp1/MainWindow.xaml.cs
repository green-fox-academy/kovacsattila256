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
            // Draw a green 10x10 square to the canvas' center.
            
            int centerPointX = 800;
            int centerPointY = 400;
            int rectCornerAX = centerPointX - 5;
            int rectCornerAY = centerPointY - 5;
            int rectCornerBX = centerPointX - 5;
            int rectCornerBY = centerPointY + 5;
            int rectCornerCX = centerPointX + 5;
            int rectCornerCY = centerPointY + 5;
            int rectCornerDX = centerPointX + 5;
            int rectCornerDY = centerPointY - 5;

            foxDraw.StrokeColor(Colors.Red);
            foxDraw.DrawLine(rectCornerAX, rectCornerAY, rectCornerBX, rectCornerBY);
            foxDraw.DrawLine(rectCornerBX, rectCornerBY, rectCornerCX, rectCornerCY);
            foxDraw.DrawLine(rectCornerCX, rectCornerCY, rectCornerDX, rectCornerDY);
            foxDraw.DrawLine(rectCornerDX, rectCornerDY, rectCornerAX, rectCornerAY);
        }
    }
}