using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04___AndAnotherExample.Model
{
    public class Person : INotifyPropertyChanged
    {
        private string name;

        public string Name
        {
            get
            {

                return name;
            }
            set
            {
                // if value has not changed then return otherwise  continue....
                if (value == name)
                {
                    return;
                }

                //if (name != value)
                //{
                //    name = value;
                //    OnPropertyChanged("Name");
                //}
                
                name = value;
                // with this method we notify the data target(textBox1) that property has changed
                OnPropertyChanged("Name");
            }
        }

       public event PropertyChangedEventHandler PropertyChanged;
       
       protected void OnPropertyChanged(string propertyName)
       {
           if (PropertyChanged != null)
           {
               PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
           }
          
       }
    }
}
