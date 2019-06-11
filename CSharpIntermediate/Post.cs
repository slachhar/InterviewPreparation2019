using System;

namespace CSharpIntermediate
{
    public class Post
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime PostCreated { get; set; }
        public int UpVote { get; set; }
        public int DownVote { get; set; }

        public int CurrentVoteValue()
        {
            return UpVote - DownVote;
        }
    }
}