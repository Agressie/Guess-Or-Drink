using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOD_V2.MVVM.Models
{
    public class MemeAPI
    {
        public string? PostLink { get; set; }
        public string? Subreddit { get; set; }
        public string? Title { get; set; }
        public string? URL { get; set; }
        public bool NSFW { get; set; }
        public bool Spoiler { get; set; }
        public string? Author { get; set; }
        public int Ups { get; set; }
        public string[]? Preview { get; set; }
    }
}
