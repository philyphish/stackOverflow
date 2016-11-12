using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOverflowPost
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Create a post: ");
            string newPost = Console.ReadLine();

            var post = new Post(newPost);
            
        }
    }
}
