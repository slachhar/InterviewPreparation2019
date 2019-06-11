using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediate
{
    class Program
    {
        static void Main(string[] args)
        {
            var stopWatch = new Stopwatch();
            stopWatch.Start();
            stopWatch.Stop();
            Console.WriteLine(stopWatch.Duration());

            var post = new Post
            {
                Title = "C# Delegates vs Linq",
                Description = "C# Delegates vs Linq"
            };
            post.UpVote++;
            post.UpVote++;
            post.UpVote++;
            post.DownVote--;
            Console.WriteLine(post.CurrentVoteValue());
        }
    }
}
