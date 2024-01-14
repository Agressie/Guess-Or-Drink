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

        private void Refresh()
        {
            categories = App.CategoryRepo.GetEntities();
        }
    }
}
