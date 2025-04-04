using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentifiableObject
{
    public class Inventory
    {
        private List<Item> _items;

        public Inventory()
        {
            _items = new List<Item>();
        }

        public bool HasItem(string id)
        {
            foreach (Item i in _items)
            {
                if (i.AreYou(id))
                {
                    return true;
                }
            }
            return false;
        }

        public void Put(Item itm)
        {
            _items.Add(itm);
        }

        public Item Take(string id)
        {
            Item take_item = this.Fetch(id);
            _items.Remove(take_item);
            return take_item;
        }

        public Item Fetch(string id)
        {
            foreach (Item i in _items)
            {
                if(i.AreYou(id))
                {
                    return i;
                }
            }
            return null;
        }

        public string ItemList
        {
            get
            {
                string item_list = "";
                foreach (Item i in _items)
                {
                    item_list = item_list + i.ShortDescription + "\n";
                }
                return item_list;
            }
        }
    }
}
