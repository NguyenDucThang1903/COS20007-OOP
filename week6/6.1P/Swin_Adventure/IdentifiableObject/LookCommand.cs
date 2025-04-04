using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentifiableObject
{
    public class LookCommand:Command
    {
        public LookCommand():base(new string[] {"look"})
        {

        }

        public override string Execute(Player p, string[] text)
        {
            if(text.Length==3 || text.Length==5)
            {
                if (text[0].ToLower() == "look")
                {
                    if (text[1].ToLower() == "at")
                    {
                        if(text.Length==3)
                        {
                            return LookAtIn(text[2], p);
                        }
                        else if(text.Length==5)
                        {
                            if (text[3].ToLower() == "in")
                            {
                                return LookAtIn(text[2], FetchContainer(p, text[4]));
                            }
                            else
                            {
                                return "What do you want to look in?";
                            }
                        }
                        else
                        {
                            return "I don't know how to look like that";
                        }
                    }
                    else return "What do you want to look at?";
                }
                else
                {
                    return "Error in look input";
                }
            }
            else
            {
                return "I don't know how to look like that";
            }
        }

        private IHaveInventory? FetchContainer(Player p, string containerId)
        {
            return p.Locate(containerId) as IHaveInventory;
        }

        private string LookAtIn(string thingId, IHaveInventory container)
        {
            if(container.Locate(thingId)!=null)
            {
                return container.Locate(thingId).FullDescription;
            }
            return "I can't find the " + thingId;
        }
    }
}
