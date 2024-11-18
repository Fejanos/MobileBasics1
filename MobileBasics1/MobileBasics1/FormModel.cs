using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;

using Xamarin.Forms;

namespace MobileBasics1
{
    public class FormModel : ObservableObject
    {

        private PersonModel currentPerson;
        public PersonModel CurrentPerson
        {
            get { return currentPerson; }
            set
            {
                currentPerson = value;
                NotifyPropertyChanged(nameof(CurrentPerson));
            }
        }
        public ICommand AddCommand { get; set; }
        public ObservableCollection<PersonModel> People { get; set; }
        private void ExecuteAddCommand(object obj)
        {
            People.Add(CurrentPerson);
            CurrentPerson = new PersonModel();
        }
        public FormModel()
        {
            CurrentPerson = new PersonModel();
            People = new ObservableCollection<PersonModel>();
            AddCommand = new Command(ExecuteAddCommand);
        }
    }
}
