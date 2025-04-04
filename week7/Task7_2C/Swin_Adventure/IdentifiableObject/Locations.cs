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

        public Locations(string name, string desc):base(new string[] {"location"}, name, desc)
        {
            _item_in_location = new Inventory();

        }

        public GameObject Locate(string id)
        {
            if(AreYou(id))
            {
                return this;
            }
            else
            {
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
    }
}
