using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace IdentifiableObject
{
    public class Player:GameObject
    {
        private Inventory _inventory;

        public Player(string name, string desc) : base(new string[] {"me", "inventory"}, name, desc)
        {
            _inventory = new Inventory();
        }

        public GameObject Locate(string id)
        {
            if (AreYou(id) == true)
            {
                return this;
            }
            else
            {
                return _inventory.Fetch(id);
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
    }
}
