using InventoryManagement.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementTest
{
    public class QuitCommandTests
    {
        [Fact]
        public void QuitCommandSuccessful()
        {
            var expectedInterface = new Helpers.TestUserInterface(new List<Tuple<string,string>>(),new List<string>
            {
                "Thank you for using Inventory Management System"
            }, new List<string>());

            var command = new QuitCommand(expectedInterface);

            var result = command.RunCommand();

            expectedInterface.Validate();

            Assert.True(result.shouldQuit, "Quit is a terminating command.");
            Assert.True(result.wasSuccessful, "Quit did not complete Successfully");
        }

    }
}
