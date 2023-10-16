using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDA_C_sh_ClassWork
{
    class People
    {
        int _age;
        public int Age 
        { 
            get { return _age; }            
            set 
            { 
                _age = value;
                PropertyChanged(this, _age);    
            }
            
        }
        public void Handler(object sender, int Age) => Console.WriteLine($"теперь возраст = {Age}");

        event PropertyChangedEventHandler PropertyChanged;


        public People()
        {
            PropertyChanged += Handler;
        }

    }

    //public delegate void PropertyChangedEventHandler (object sender, PropertyChangedEventArgs e);
    public delegate void PropertyChangedEventHandler(object sender, int Age);

}
