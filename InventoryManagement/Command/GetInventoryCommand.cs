using InventoryManagement.UserInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Command
{
    public class GetInventoryCommand : NonTerminatingCommand
    {
        public GetInventoryCommand(IUserInterface userInterface) : base(userInterface)
        {
        }

        protected override bool InternalCommand()
        {
            throw new NotImplementedException("Implemented in next chapter!");
        }
    }
}
