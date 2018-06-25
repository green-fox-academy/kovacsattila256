using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication5.Models
{
    public class Greeting
    {
        public static long IdCount { get; set; }
        public long Id { get; set; }
        public string Content { get; set; }

        public Greeting(string name)
        {
            Content = name;
            Id = IdCount++;
        }

        public Greeting()
        {
            Id = IdCount++;
        }
    }
}
