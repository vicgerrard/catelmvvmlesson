using System.Collections.ObjectModel;
using Catel.Collections;
using CatelMvvmLesson.Models;

namespace CatelMvvmLesson.ViewModels
{
    using Catel.MVVM;
    using System.Threading.Tasks;

    public class MainWindowViewModel : ViewModelBase
    {
        public ObservableCollection<Human> Humans { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public Command AddHumanCommand { get; set; }

        public MainWindowViewModel()
        {
            Humans = new ObservableCollection<Human>();
            AddHumanCommand = new Command(() =>
            {
                var human = new Human
                {
                    Name = Name,
                    LastName = LastName
                };
                Humans.Add(human);
                Name = LastName = string.Empty;
            }, () => !string.IsNullOrEmpty(Name) && !string.IsNullOrEmpty(LastName));
        }

        public override string Title { get { return "CatelMvvmLesson"; } }

    }
}
