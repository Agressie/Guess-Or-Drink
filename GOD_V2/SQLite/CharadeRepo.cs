using GOD_V2.MVVM.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOD_V2.SQLite
{
    internal class CharadeRepo
    {
        SQLiteConnection connection;
        public string? statusMessage { get; set; }

        public CharadeRepo()
        {
            connection = new SQLiteConnection(Constants.DatabasePath, Constants.flags);
            connection.CreateTable<Charade>();
        }

        public void AddorUpdateCharade(Charade newcharade)
        {
            int result = 0;
            try
            {
                if (newcharade.id != 0)
                {
                    result = connection.Update(newcharade);
                    statusMessage = $"{result} Row(s) updated;";
                }
                else
                {
                    result = connection.Insert(newcharade);
                    statusMessage = $"{result} Row(s) added";
                }
            }
            catch (Exception ex)
            {
                statusMessage = $"Error: {ex.Message}";
            }
        }
        public List<Charade>? GetCharades()
        {
            try
            {
                var Chartable = connection.Table<Charade>().ToList();
                if (Chartable == null)
                    statusMessage = $"Error: Table is empty";
                else
                    return connection.Table<Charade>().ToList();
            }
            catch (Exception ex) 
            {
                statusMessage = $"Error: {ex.Message}";
            }
            return null;
        }
        public Charade? GetSpecificCharade(int id)
        {
            try
            {
                var Chartable = connection.Table<Charade>().ToList();
                if (Chartable == null)
                    statusMessage = $"Error: Table is empty";
                else
                    return connection.Table<Charade>().FirstOrDefault(x => x.id == id);
            }
            catch (Exception ex)
            {
                statusMessage = $"Error: {ex.Message}";
            }
            return null;
        }

        public void DeleteCharade(int id)
        {
            int result = 0;
            try
            {
                Charade charade = GetSpecificCharade(id);
                result = connection.Delete(charade);
                statusMessage = $"{result} Row(s) Deleted";
            }
            catch (Exception ex)
            {
                statusMessage = $"Error: {ex.Message}";
            }
        }
    }
}
