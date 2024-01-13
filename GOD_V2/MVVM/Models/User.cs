using GOD_V2.SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOD_V2.MVVM.Models
{
    public class User : TableData
    {
        public string Password { get; set; }

        public User(string name, string password)
        {
            this.name = name;
            this.Password = password;
        }
    }

    
}
