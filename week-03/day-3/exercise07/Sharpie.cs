using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Sharpie
    {
        private string Color;
        private float Width;
        private float InkAmount;

        public Sharpie(string color, float width, float inkAmount)
        {
            Color = color;
            Width = width;
            InkAmount = 100;
        }
        public void use()
        {
            InkAmount -= 1;
        }
    }
}
