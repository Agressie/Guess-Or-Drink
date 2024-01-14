using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GOD_V2;

namespace GOD_V2.SQLite
{
    public class TableData
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [Column("name"), Unique]
        public string Name { get; set; }
    }
}
