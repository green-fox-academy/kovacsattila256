using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Create Sharpie class

    We should know about each sharpie their Color (which should be a string), Width 
    (which will be a floating point number), InkAmount (another floating point number)
    When creating one, we need to specify the Color and the Width
    Every sharpie is created with a default 100 as InkAmount
    We can Use() the sharpie objects
        which decreases inkAmount
*/

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            Sharpie colorBlue = new Sharpie("blue",5,100);
            Sharpie colorRed = new Sharpie("red",4,100);
            Sharpie colorBlack = new Sharpie("black",5,100);
        }
    }
}
