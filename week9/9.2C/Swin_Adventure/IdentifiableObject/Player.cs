using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace IdentifiableObject
{
    public class Player:GameObject, IHaveInventory
    {
        private Inventory _inventory;
        private Locations _location;

        public Player(string name, string desc) : base(new string[] {"me", "inventory"}, name, desc)
        {
            _inventory = new Inventory();
        }

        public GameObject Locate(string id)
        {
            if (AreYou(id)==true)
            {
                return this;
            }
            else if(_inventory.Fetch(id)!=null)
            {
                return _inventory.Fetch(id);
            }
            else if (_location!=null)
            {
                return _location.Locate(id);
            }
            else
            {
                return null;
            }

        }

        public override string FullDescription
        {
            get
            {
                return $"You are ({Name}), ({base.FullDescription}). You are carrying:\n{_inventory.ItemList}";
            }
        }

        public Inventory Inventory
        {
            get
            {
                return _inventory;
            }
        }

        public Locations Location
        {
            get
            {
                return _location;
            }
            set
            {
                _location = value;
            }
        }

        public void Move(Path path)
        {
            if (path.Destination!=null)
            {
                _location = path.Destination;
            }
        }
    }
}
