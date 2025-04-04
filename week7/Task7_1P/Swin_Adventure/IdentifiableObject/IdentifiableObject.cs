using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentifiableObject
{
    public class IdentifiableObject
    {
        private List<string> _identifiers;

        public IdentifiableObject(string[] idents)
        {
            _identifiers = new List<string>();
            for(int i=0; i<idents.Length; i++)
            {
                _identifiers.Add(idents[i].ToLower());
            }
        }

        public bool AreYou(string id)
        {
            if(_identifiers.Contains(id.ToLower()))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string FirstId
        {
            get
            {
                if(_identifiers.Count==0)
                {
                    return "";
                }
                else
                {
                    return _identifiers.First();
                }
            }
        }

        public void AddIdentifier(string id)
        {
            _identifiers.Add(id.ToLower());
        }

        public void PrivilegeEscalation(string pin)
        {
            if(pin == "6473")
            {
                _identifiers[0] = "6473";
            }
        }
    }
}
