using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOD_V2.MVVM.Models
{
    internal class Category
    {
        [PrimaryKey, AutoIncrement]
        public int id { get; set; }

        [MaxLength(64)]
        public string? name { get; set; }

        public List<Charade> Charades = new List<Charade>();
    }
}
