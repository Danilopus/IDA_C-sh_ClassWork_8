using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDA_C_sh_ClassWork_8
{
    internal class TrueVector<any> 
    //internal class TrueVector<any> : INumerable<any>

    {

        any[] _list_of_values;
        int size = 0;
        public TrueVector() : this(10) { }
        public TrueVector(int capacity)
        {

            _list_of_values = new any[capacity];
        }
        public void Add(any new_value)
        {
            any[] tmp1;
            if (size >= _list_of_values.Length)
            {
                tmp1 = new any[_list_of_values.Length * 2];
                for (int i = 0; i < _list_of_values.Length; i++)
                    tmp1[i] = _list_of_values[i];
                _list_of_values = tmp1;
            }

                _list_of_values[size] = new_value;          


                size++;    

        }
        public int Length()
        { return size;}
        public void Clear()
        {
            _list_of_values = new any[10];
        }

        public any Pop()
        {
            size--;
            return _list_of_values[size + 1];
        }
        public any this[int index]
            {
            get { return _list_of_values[index]; }
            set { _list_of_values[index] = value; }
            }

    }
}
