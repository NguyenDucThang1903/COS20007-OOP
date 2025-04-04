using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentifiableObject
{
    public class CommandHandler:Command
    {
        List<Command> _commands;

        public CommandHandler() : base(new string[] { "command" })
        {
            _commands = new List<Command>();
            _commands.Add(new LookCommand());
            _commands.Add(new MoveCommand());
        }

        public override string Execute(Player p, string[] text)
        {
            foreach (Command c in _commands)
            {
                if (c.AreYou(text[0].ToLower()))
                {
                    return c.Execute(p, text);
                }
            }
            return "Your command is wrong";
        }
    }
}
