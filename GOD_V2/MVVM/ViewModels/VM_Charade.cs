using GOD_V2.MVVM.Models;
using PropertyChanged;
using System.Windows.Input;

namespace GOD_V2.MVVM.ViewModels
{
    [AddINotifyPropertyChangedInterface]
    public class VM_Charade
    {
        public Charade? currentcharade { get; set; }
        public List<Charade>? charades { get; set; }
        public ICommand? AddOrUpdateCommand { get; set; }
        public ICommand? DeleteCommand { get; set; }


        public VM_Charade()
        {
            Refresh();
            AddOrUpdateCommand = new Command(async () =>
            {
                App.CharadeRepo.SaveEntity(currentcharade);
                Console.WriteLine(App.CharadeRepo.statusMessage);
                Refresh();
            });

            DeleteCommand = new Command(async () =>
            {
                App.CharadeRepo.DeleteEntity(currentcharade);
                Console.WriteLine(App.CharadeRepo.statusMessage);
                Refresh();
            });
        }

        private void Refresh()
        {
            charades = App.CharadeRepo.GetEntities();
        }
    }
}
