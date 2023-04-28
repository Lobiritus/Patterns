using InventoryManagement.UserInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Command
{
    public class UnknownCommand : NonTerminatingCommand
    {
        public UnknownCommand(IUserInterface userInterface) : base(userInterface)
        {
        }

        protected override bool InternalCommand()
        {
            Interface.WriteWarning("Unable to determine the desired command.");

            return false;
        }
    }
    }
