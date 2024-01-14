using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GOD_V2;
using GOD_V2.MVVM.Models;
using SQLite;

namespace GOD_V2.SQLite
{
    public class BaseRepo<T> : IBaseRepo<T> where T : TableData, new()
    {
        SQLiteConnection connection;
        public string? statusMessage { get; set; }

        public BaseRepo()
        {
            connection = new SQLiteConnection(Constants.DatabasePath, Constants.flags);
            connection.CreateTable<T>();
        }
        public void DeleteEntity(T entity)
        {
            try
            {
                var result = connection.Delete(entity);
                statusMessage = $"{result} Row(s) Deleted";
            }
            catch (Exception ex)
            {
                statusMessage = $"Error: {ex.Message}";
            }
        }

        public void Dispose()
        {
            connection.Dispose();
        }

        public List<T>? GetEntities()
        {
            try
            {
                var table = connection.Table<T>().ToList();
                if (table == null)
                {
                    statusMessage = $"Error: Table is empty";
                    return null;
                }
                else
                    return table;
            }
            catch (Exception ex)
            {
                statusMessage = $"Error: {ex.Message}";
            }
            return null;
        }

        public T? GetSpecificEntity(int id)
        {
            try
            {
                var table = connection.Table<T>().ToList();
                if (table == null)
                {
                    statusMessage = $"Error: Table is empty";
                    return null;
                }
                else
                    return connection.Table<T>().FirstOrDefault(x => x.Id == id);
            }
            catch (Exception ex)
            {
                statusMessage = $"Error: {ex.Message}";
            }
            return null;
        }

        public void SaveEntity(T entity)
        {
            try
            {
                if (entity.Id != 0)
                {
                    var result = connection.Update(entity);
                    statusMessage = $"{result} Row(s) updated;";
                }
                else
                {
                    var result = connection.Insert(entity);
                    statusMessage = $"{result} Row(s) added";
                }
            }
            catch (Exception ex)
            {
                statusMessage = $"Error: {ex.Message}";
            }
        }
    }
}
