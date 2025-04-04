using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentifiableObject
{
    public class Locations:GameObject, IHaveInventory
    {
        private Inventory _item_in_location;
        private List<Path> _paths;

        public Locations(string name, string desc):base(new string[] {"location"}, name, desc)
        {
            _item_in_location = new Inventory();
            _paths = new List<Path>();
        }

        public Locations(string name, string desc, List<Path> paths) : this(name, desc)
        {
            _paths = paths;
        }

        public GameObject Locate(string id)
        {
            if(AreYou(id))
            {
                return this;
            }
            else
            {
                foreach (Path p in _paths)
                {
                    if (p.AreYou(id))
                    {
                        return p;
                    }
                }
                return _item_in_location.Fetch(id);
            }
        }

        public Inventory ItemInLocation
        {
            get
            {
                return _item_in_location;
            }
        }

        public override string FullDescription
        {
            get
            {
                return $"Welcome, {base.FullDescription}\nIn this location you can see:\n{ItemInLocation.ItemList} ";
            }
        }

        public void AddPath(Path path)
        {
            _paths.Add(path);
        }




        public override string ShortDescription
        {
            get
            {
                return "You are in a " + Name;
            }
        }
    }
}
