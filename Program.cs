using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            post post1 = new post("Thanks for the birthday wishes", true, "Ivan Birch");
            Console.WriteLine(post1.ToString());
            ImagePost imagePost1 = new ImagePost("Look what happened this morning",
                "Ivan Birch", "Https://underbox.co.za/today", true);
            Console.WriteLine(imagePost1.ToString());
            Console.ReadLine();
        }
    }
}
