using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using yoxlama.Models;

namespace yoxlama.ViewModels
{
    public class PersonViewModel : INotifyPropertyChanged
    {

        private Person _person;

        public Person Person
        {
            get { return _person; }
            set { _person = value;
                OnPropertyChanged(nameof(Person));  
            }
        }

        public PersonViewModel() => Person = new Person();

        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


    }
}
