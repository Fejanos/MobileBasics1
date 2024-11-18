using System;
using System.Collections.Generic;
using System.Text;

namespace MobileBasics1
{
    public class PersonModel : ObservableObject
    {
        private string id;
        public string Id
        {
            get { return id; }
            set
            {
                id = value;
                NotifyPropertyChanged(nameof(Id));
            }
        }
        private string name;
        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                NotifyPropertyChanged(nameof(Name));
            }
        }
        private int age;
        public int Age
        {
            get { return age; }
            set
            {
                age = value;
                NotifyPropertyChanged(nameof(Age));
            }
        }
        public override string ToString()
        {
            return String.Format($"{id}, {name}, {age}");
        }
    }
}
