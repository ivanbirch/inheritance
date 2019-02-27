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
            //Challenge - add a deriving class "VideoPost with properties VideoUrl and Length

            //create the required constructors to create a VideoPost
            //adjust the ToString() method accordingly
            //create an instance of VideoPost and use the ToString() method on it

            VideoPost videoPost1 = new VideoPost("Look what happened last week",
                "Ivan Birch", "Https://underbox.co.za/lastweek", true);
            Console.WriteLine(videoPost1.ToString());
            Console.ReadLine();
        }
    }
}
