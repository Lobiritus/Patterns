using InventoryManagement.UserInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Command
{
    public class UpdateQuantityCommand : NonTerminatingCommand, IParameterisedCommand
    {

        public UpdateQuantityCommand(IUserInterface userInterface) : base(userInterface)
        {
        }

        internal string InventoryName { get; private set; }

        private int _quantity;
        internal int Quantity { get => _quantity; private set => _quantity = value; }

        public bool GetParameters()
        {
            if (string.IsNullOrWhiteSpace(InventoryName))
                InventoryName = GetParameter("name");

            if (Quantity == 0)
                int.TryParse(GetParameter("quantity"), out _quantity);

            return !string.IsNullOrWhiteSpace(InventoryName) && Quantity != 0;
        }

        protected override bool InternalCommand()
        {
            throw new NotImplementedException("Implemented in next chapter!");
        }
    }
}
