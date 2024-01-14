using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOD_V2.MVVM
{
    internal class Team
    {
        public string Name { get; set; }
        public int rightanswers { get; set; } = 0;

        public Team(string name)
        {
            this.Name = name;
        }
    }
}
