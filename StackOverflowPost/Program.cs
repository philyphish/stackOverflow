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
           
            Console.WriteLine("Please vote on this post. Type 1 for and up-vote and 0 for a down-vote.");
            int newVote = Convert.ToInt16(Console.ReadLine());
            var vote = new Post(newVote);
            


        }
    }
}
