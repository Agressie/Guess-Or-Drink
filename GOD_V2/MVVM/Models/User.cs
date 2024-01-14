using GOD_V2.SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOD_V2.MVVM.Models
{
    public class User : TableData
    {
        //[MaxLength(64)]
        public string Password { get; set; }
    }

    
}
