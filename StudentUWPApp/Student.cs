using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace StudentUWPApp
{
    class Student : INotifyPropertyChanged
    {
        private string _name;
        private int _StudentID;
        public event PropertyChangedEventHandler PropertyChanged;
        public Student(string name, int studentID)
        {
            _name = name;
            _StudentID = studentID;
        }

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
                this.OnPropertyChanged();
            }
        }

        public int StudentID
        {
            get
            {
                return _StudentID;
            }
            set
            {
                _StudentID = value;
                this.OnPropertyChanged();
            }
        }

        public void OnPropertyChanged([CallerMemberName] string propertyName = null) => this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
