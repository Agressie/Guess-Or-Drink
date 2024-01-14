using GOD_V2.MVVM.Models;
using PropertyChanged;
using System.Windows.Input;
using GOD_V2;

namespace GOD_V2.MVVM.ViewModels
{
    [AddINotifyPropertyChangedInterface]
    public class VM_Category
    {
        public Category? currentcategory { get; set; }
        public static List<Category> categories = new List<Category>();
        public string? colorhex { get; set; }

        private static void Refresh()
        {
            categories = App.CategoryRepo.GetEntities();
        }

        //Because i don't save the categorys to the database i have to search in the list of categories.
        // The original code that refers to the baserepo is commented out.
        public static Category GetCategory(int id)
        {
            // Category category = App.CategoryRepo.GetSpecificEntity(id);
            foreach (Category cat in categories)
            {
                if (cat.Id == id) 
                    return cat;
            }
            return null;
        }

        // So, what this function would do is check if there are category's in the DB. If there isn't then it creates 4 and with the createcategory function
        // it would try to save them to the database, execpt the code gives errors that cause the app to crash. Because im at a bit of an dead end on what to do.
        // i chose to create the category's everytime the app opens. so that for now i can continue on the app development.
        public static void initCategoryDB()
        {
            //var result = App.CategoryRepo.Checkifempty();
            var result = true;
            if (result == true) 
            {
                Category Happyhour = new Category();
                Category Ontherocks = new Category();
                Category Lastcall = new Category();
                Category Spicy = new Category();
                Happyhour.Id = 0;
                Happyhour.Name = "Happyhour";
                Happyhour.color = "#E7F08F";
                Ontherocks.Id = 1;
                Ontherocks.Name = "On The Rocks";
                Ontherocks.color = "#EDA810";
                Lastcall.Id = 2;
                Lastcall.Name = "Last Call";
                Lastcall.color = "#ED3510";
                Spicy.Id = 3;
                Spicy.Name = "Spicy";
                Spicy.color = "#A11111";
                categories.Add(Happyhour);
                categories.Add(Ontherocks);
                categories.Add(Lastcall);
                categories.Add(Spicy);
            }
        }

        // This is the createcategory function, i commented out the code that was here prevously so that it doesn't clutter the database and just adds the,
        // Category's to the categories list. 
        public static void createcategory(Category category)
        {
            //Refresh();
            //App.CategoryRepo.SaveEntity(category);
            //Console.WriteLine(App.UserRepo.statusMessage);
            categories.Add(category);
        }
    }
}
