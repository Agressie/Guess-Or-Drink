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
        public List<Category>? categories { get; set; }
        public string? colorhex { get; set; }

        private void Refresh()
        {
            categories = App.CategoryRepo.GetEntities();
        }

        public static Category GetCategory(int id)
        {
            Category category = App.CategoryRepo.GetSpecificEntity(id);
            return category;
        }

        public void initCategoryDB()
        {
            Refresh();
            var result = App.CategoryRepo.Checkifempty();
            if (result == true) 
            {
                Category Happyhour = new Category();
                Category Ontherocks = new Category();
                Category Lastcall = new Category();
                Category Spicy = new Category();
                Happyhour.Name = "Happyhour";
                Happyhour.color = "#E7F08F";
                Ontherocks.Name = "On The Rocks";
                Ontherocks.color = "#EDA810";
                Lastcall.Name = "Last Call";
                Lastcall.color = "#ED3510";
                Spicy.Name = "Spicy";
                Spicy.color = "#A11111";
                createcategory(Happyhour);
                createcategory(Ontherocks);
                createcategory(Lastcall);
                createcategory(Spicy);
            }
        }

        public void createcategory(Category category)
        {
            Refresh();
            App.CategoryRepo.SaveEntity(category);
            Console.WriteLine(App.UserRepo.statusMessage);
        }
    }
}
