using System;
using System.IO;

namespace Example
{
    class Program
    {

        /*
        Create a PostIt a struct that has
        a BackgroundColor
        a Text on it
        a TextColor
        Create a few example post-it objects:
        an orange with blue text: "Idea 1"
        a pink with black text: "Awesome"
        a yellow with green text: "Superb!"
        */
        static void Main(string[] args)
        {
            PostIt idea1 = new PostIt("orange", "Idea 1", "blue");
            PostIt awesome = new PostIt("pink", "Awesome", "black");
            PostIt superb = new PostIt("yellow", "Superb", "green");

            Console.WriteLine(idea1.backGroundColor);
            Console.ReadLine();
        }
        public struct PostIt
        {
            public string backGroundColor;
            public string textOnIt;
            public string textColor;

            public PostIt(string backGroundColor, string textOnIt, string textColor)
            {
                this.backGroundColor = backGroundColor;
                this.textOnIt = textOnIt;
                this.textColor = textColor;
            }
        }
    }

}

