using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOverflowPost
{
    public class Post
    {
        private DateTime createDate;
        private string _post;
        private int voteCount;
        private static int vote;

        public Post()
        {

        }

        public void upVote()    
        {
            vote = ++vote;
        }

        public void downVote()
        {
            vote = --vote;
        }

        public Post(string tittle, string description, string post)
        {
            this._post = post;
            this.createDate = DateTime.Now;
            Console.WriteLine("Tittle: {0}", tittle);
            Console.WriteLine("Description: {0}", description);
            Console.WriteLine("Create Date: {0}", createDate);
            Console.WriteLine("Ranking: {0}", vote);
            Console.WriteLine("Post: {0}", post);
        }

        public static void voting(int vote)
        {
            var rank = new Post();
            switch (vote)
            {
                case 0:
                    rank.downVote();
                    break;
                case 1:
                    rank.upVote();
                    break;
                    defualt:
                    Console.WriteLine("Invalid vote.");
            }
        }
        //public Post(int vote)
        //{
        //    this._vote = vote;

        //    if (vote == 1)
        //    {
        //        voteCount++;
        //    }
        //    else if(vote == 0)
        //    {
        //        voteCount--;
        //    }
        //    else
        //    {
        //        Console.WriteLine("This is not a valid vote.");
        //    }

        //}

    }
}
