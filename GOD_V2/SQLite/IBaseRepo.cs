using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace GOD_V2.SQLite
{
    internal interface IBaseRepo<T> :IDisposable where T : TableData, new()
    {
        void SaveEntity(T entity);
        T? GetSpecificEntity(int id);
        List<T>? GetEntities();
        void DeleteEntity(T entity);
    }
}
