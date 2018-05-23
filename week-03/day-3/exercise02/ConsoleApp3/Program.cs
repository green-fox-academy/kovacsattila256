using System;
using System.IO;

namespace ConsoleApp3
{
    /*
   Create a BlogPost class that has
    an AuthorName
    a Title
    a Text
    a PublicationDate
   Create a few blog post objects:
    "Lorem Ipsum" titled by John Doe posted at "2000.05.04."
        Lorem ipsum dolor sit amet.
    "Wait but why" titled by Tim Urban posted at "2010.10.10."
        A popular long-form, stick-figure-illustrated blog about almost everything.
    "One Engineer Is Trying to Get IBM to Reckon With Trump" titled by William Turton at "2017.03.28."
    Daniel Hanley, a cybersecurity engineer at IBM, doesn’t want to be the center of attention. When I asked to take his picture outside one of IBM’s New York City offices, he told me that he wasn’t really into the whole organizer profile thing.
     */
    class Program
    {
        public static void Main(string[] args)
        {
            BlogPost Loremipsum = new BlogPost("John Doe", "Lorem Ipsum", "Lorem ipsum dolor sit amet", new DateTime(2000, 05, 04));
            BlogPost Waitbutwhy = new BlogPost("Tim Urban", "Wait but why", "A popular long-form, stick-figure-illustrated blog about almost everything.", new DateTime(2010, 10, 10));
            BlogPost OneEngineer = new BlogPost("William Turton", "One Engineer Is Trying to Get IBM to Reckon With Trump", "Daniel Hanley, a cybersecurity engineer at IBM, doesn’t want to be the center of attention. When I asked to take his picture outside one of IBM’s New York City offices, he told me that he wasn’t really into the whole organizer profile thing.", new DateTime(2010, 10, 10));

            Console.WriteLine(Loremipsum.Text + "   " + Loremipsum.PublicationDate);
            Console.ReadKey();
        }
    }
}

