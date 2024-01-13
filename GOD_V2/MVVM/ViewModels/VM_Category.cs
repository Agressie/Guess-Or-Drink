using GOD_V2.MVVM.Models;
using PropertyChanged;
using System.Windows.Input;

namespace GOD_V2.MVVM.ViewModels
{
    [AddINotifyPropertyChangedInterface]
    public class VM_Category
    {
        public Category? currentcategory { get; set; }
        public List<Category>? categories { get; set; }
        public ICommand? AddOrUpdateCommand { get; set; }
        public ICommand? DeleteCommand { get; set;}


        public VM_Category()
        {
            Refresh();
            AddOrUpdateCommand = new Command(async () =>
            {
                App.CategoryRepo.SaveEntity(currentcategory);
                Console.WriteLine(App.CategoryRepo.statusMessage);
                Refresh();
            });

            DeleteCommand = new Command(async () =>
            {
                App.CategoryRepo.DeleteEntity(currentcategory);
                Console.WriteLine(App.CategoryRepo.statusMessage);
                Refresh();
            });
        }

        private void Refresh()
        {
            categories = App.CategoryRepo.GetEntities();
        }
    }
}
