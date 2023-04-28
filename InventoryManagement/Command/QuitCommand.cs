using InventoryManagement.UserInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Command
{
    public class QuitCommand : InventoryCommand
    {
        public QuitCommand(IUserInterface userInterface) : base(true, userInterface)
        {
        }

        protected override bool InternalCommand()
        {
            Interface.WriteMessage("Thank you for using Inventory Management System");

            return true;
        }
    }
}
