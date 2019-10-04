using System;

namespace CSharpIntermediate
{
    public class Post
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreatedOn { get; set; }
        public int Votes{ get; private set; }

        public void UpVote()
        {
            Votes++; }

        public void DownVote()
        {
            Votes--;
        }
    }
}