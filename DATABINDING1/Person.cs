using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATABINDING1
{
    public class Person : INotifyPropertyChanged
    {
        private string name;
        private string address;

        public string Name
        {
            get { return name; }
            set { name = value; 
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("Name"));
                }
            }
        }

        public string Address
        {
            get { return address;  }
            set { address = value; 
                if(PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("Address"));
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
