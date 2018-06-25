using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication4.Models
{
    public class Greeting
    {
        public static long id_ka { get; set; }
        public int id  { get; set; }
        public string content { get; set; }

        public Greeting(string content)
        {
            this.content = content;
        }

        public Greeting()
        {
            id_ka++;
            id = (int)id_ka;
        }
    }
}
