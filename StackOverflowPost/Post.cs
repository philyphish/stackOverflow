using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOverflowPost
{
    class Post
    {
        private string title;
        private string description;
        private DateTime createDate;
        private int _vote;
        private string _post;
        private int voteCount;
        public Post(string post)
        {
            this._post = post;
            this.createDate = DateTime.Now;
            
            Console.WriteLine(post + " " + createDate + " " +"");
        }
        public Post(int vote)
        {
            this._vote = vote;

            if (vote == 1)
            {
                voteCount++;
            }
            else if(vote == 0)
            {
                voteCount--;
            }
            else
            {
                Console.WriteLine("This is not a valid vote.");
            }

        }
    }
}
