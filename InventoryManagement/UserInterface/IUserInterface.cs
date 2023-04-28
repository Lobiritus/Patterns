using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.UserInterface
{
    public interface IUserInterface : IReadUserInterface, IWriteUserInterface { }

}
