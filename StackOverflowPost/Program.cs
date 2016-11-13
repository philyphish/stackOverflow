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
            
            Console.WriteLine("Create a post! First enter your post's tittle.");
            string tittle = Console.ReadLine();
            Console.WriteLine("Plese enter a description of your post.");
            string description = Console.ReadLine();
            Console.WriteLine("Enter a short post.");
            string newPost = Console.ReadLine();
            var vote = new Post();
            Console.WriteLine("Please vote on this post. Type 1 for and up-vote and 0 for a down-vote.");
            Post.voting(Convert.ToInt16(Console.ReadLine()));
            
            var post = new Post(tittle, description, newPost);
        }
    }
}
