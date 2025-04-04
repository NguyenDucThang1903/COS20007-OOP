using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mid_sem_test
{
    public class Folder:Thing
    {
        private List<Thing> _contents;

        public Folder(string name) : base(name)
        {
            _contents = new List<Thing>();
        }

        public void Add(Thing toAdd)
        {
            _contents.Add(toAdd);
        }

        public override int Size()
        {
            int cnt = 0;
            foreach (Thing t in _contents)
            {
                cnt += t.Size();
            }
            return cnt;
        }

        public override void Print()
        {
            if(_contents.Count == 0)
            {
                Console.WriteLine($"The Folder: '{this.Name}' is empty!");
            }
            else
            {
                Console.WriteLine($"The Folder: '{this.Name}' contains {_contents.Count} files totalling {Size()} bytes:");
            }

            foreach (Thing f in _contents)
            {
                f.Print();
            }
        }
    }
}
