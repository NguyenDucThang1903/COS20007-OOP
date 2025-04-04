using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentifiableObject
{
    public class MoveCommand:Command
    {
        public MoveCommand():base(new string[] {"move"})
        {

        }

        public override string Execute(Player p, string[] text)
        {
            
            if(text.Length==2)
            {
                if(text[0].ToLower()=="move")
                {
                    GameObject path = p.Location.Locate(text[1]);
                    if(path!=null)
                    {
                        if(path is not Path _path)
                        {
                            return "Can't find the " + path.Name;
                        }
                        else
                        {
                            p.Move((Path)path);
                            return $"You go {path.FirstId}\nWent through the {path.Name}\nArrived to the {p.Location.Name}";
                        }
                    }
                    else
                    {
                        return "There's no path like that";
                    }
                }
                else
                {
                    return "Wrong format of the command";
                }
            }
            else
            {
                return "I don't know how to move like that.";
            }
        }
    }
}
