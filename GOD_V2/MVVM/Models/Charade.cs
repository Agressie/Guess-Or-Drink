using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOD_V2.MVVM.Models
{
    internal class Charade
    {
        [PrimaryKey, AutoIncrement]
        public int id { get; set; }

        [Column("charade"), Indexed]
        public string? _charade { get; set; }

        [ForeignKey(typeof(Category))]
        public Category? category { get; set; }
    }
}
