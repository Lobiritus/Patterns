using InventoryManagement.UserInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Command
{
    public abstract class NonTerminatingCommand : InventoryCommand
    {
        protected NonTerminatingCommand(IUserInterface userInterface) : base(commandIsTerminating: false, userInteface: userInterface)
        {
        }
    }
}
