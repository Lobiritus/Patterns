using InventoryManagement.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementTest
{
    public class UnknownCommandTests
    {
        [Fact]
        public void UnknownCommand_Successful()
        {
            var expectedInterface = new Helpers.TestUserInterface(
                new List<Tuple<string, string>>(),
                new List<string>(),
                new List<string>
                {
                    "Unable to determine the desired command."
                }
            );

            
            var command = new UnknownCommand(expectedInterface);

            var result = command.RunCommand();

            Assert.False(result.shouldQuit, "Unknown is not a terminating command.");
            Assert.False(result.wasSuccessful, "Unknown should not complete Successfully.");
        }
    }
}
