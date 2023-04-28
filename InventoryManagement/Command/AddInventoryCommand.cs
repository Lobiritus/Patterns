using InventoryManagement.UserInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Command
{
    public class AddInventoryCommand : NonTerminatingCommand, IParameterisedCommand
    {
        public AddInventoryCommand(IUserInterface userInterface) : base(userInterface)
        {
        }

        public string InventoryName { get; private set; }


        public bool GetParameters()
        {
            if (string.IsNullOrWhiteSpace(InventoryName))
                InventoryName = GetParameter("name");

            return !string.IsNullOrWhiteSpace(InventoryName);
        }

        protected override bool InternalCommand()
        {
            throw new NotImplementedException("Implemented in next chapter!");
        }
    }
}
