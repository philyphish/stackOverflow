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

        public Post(string post)
        {
            this._post = post;
            Console.WriteLine(post + " " +DateTime.Now);
        }

        public Post(int vote)
        {
            this._vote = vote;
        }

        
    }
}
