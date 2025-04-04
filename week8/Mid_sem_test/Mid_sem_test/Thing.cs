using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mid_sem_test
{
    public abstract class Thing
    {
        private string _name;

        public Thing(string name)
        {
            _name = name;
        }

        public abstract int Size();

        public abstract void Print();

        public string Name
        {
            get
            {
                return _name;
            }
        }
    }
}
