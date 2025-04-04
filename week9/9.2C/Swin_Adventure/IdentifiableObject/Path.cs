using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentifiableObject
{
    public class Path:GameObject
    {
        private bool _block;
        private Locations _current_location;
        private Locations _destination;

        public Path(string[] ids, string name, string desc, Locations current_location, Locations destination):base(ids, name, desc)
        {
            _block = false;
            _current_location = current_location;
            _destination = destination;
            AddIdentifier("path");
            foreach (string s in name.Split(" "))
            {
                AddIdentifier(s);
            }
        }

        public Locations Destination
        {
            get
            {
                return _destination;
            }
        }

        public override string FullDescription
        {
            get
            {
                return Name;
            }
        }

        public bool Block
        {
            get
            {
                return _block;
            }
            set
            {
                _block = value;
            }
        }
    }
}
