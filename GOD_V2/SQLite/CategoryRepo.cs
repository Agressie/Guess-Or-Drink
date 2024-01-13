using GOD_V2.MVVM.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOD_V2.SQLite
{
    internal class CategoryRepo
    {
        SQLiteConnection connection;
        public string? statusMessage { get; set; }

        public CategoryRepo()
        {
            connection = new SQLiteConnection(Constants.DatabasePath, Constants.flags);
            connection.CreateTable<Category>();
        }

        public void AddorUpdatecategory(Category newcategory)
        {
            int result = 0;
            try
            {
                if (newcategory.id != 0)
                {
                    result = connection.Update(newcategory);
                    statusMessage = $"{result} Row(s) updated;";
                }
                else
                {
                    result = connection.Insert(newcategory);
                    statusMessage = $"{result} Row(s) added";
                }
            }
            catch (Exception ex)
            {
                statusMessage = $"Error: {ex.Message}";
            }
        }
        public List<Category>? GetCategory()
        {
            try
            {
                var Cattable = connection.Table<Category>().ToList();
                if (Cattable == null)
                    statusMessage = $"Error: Table is empty";
                else
                    return connection.Table<Category>().ToList();
            }
            catch (Exception ex)
            {
                statusMessage = $"Error: {ex.Message}";
            }
            return null;
        }
        public Category? GetSpecificCategory(int id)
        {
            try
            {
                var Cattable = connection.Table<Category>().ToList();
                if (Cattable == null)
                    statusMessage = $"Error: Table is empty";
                else
                    return connection.Table<Category>().FirstOrDefault(x => x.id == id);
            }
            catch (Exception ex)
            {
                statusMessage = $"Error: {ex.Message}";
            }
            return null;
        }

        public void DeleteCategory(int id)
        {
            int result = 0;
            try
            {
                Category category = GetSpecificCategory(id);
                result = connection.Delete(category);
                statusMessage = $"{result} Row(s) Deleted";
            }
            catch (Exception ex)
            {
                statusMessage = $"Error: {ex.Message}";
            }
        }
    }
}
