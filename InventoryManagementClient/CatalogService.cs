using InventoryManagement.UserInterface;
using InventoryManagement.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementClient
{
    interface ICatalogService
    {
        void Run();
    }
    public class CatalogService : ICatalogService
    {
        private readonly IUserInterface _userInterface;

        public CatalogService(IUserInterface userInterface)
        {
            _userInterface = userInterface;
        }

        public void Run()
        {
            Greeting();

            var response = GetCommand("?").RunCommand();

            while (!response.shouldQuit)
            {

                var input = _userInterface.ReadValue("> ").ToLower();
                var command = GetCommand(input);

                response = command.RunCommand();

                if (!response.wasSuccessful)
                {
                    _userInterface.WriteMessage("Enter ? to view options.");
                }
            }
        }

        private void Greeting()
        {
            var version = Assembly.GetExecutingAssembly().GetName().Version.ToString();
        }

        public InventoryCommand GetCommand(string input)
        {
            switch (input)
            {
                case "q":
                case "quit":
                    return new QuitCommand(_userInterface);
                case "a":
                case "addinventory":
                    return new AddInventoryCommand(_userInterface);
                case "g":
                case "getinventory":
                    return new GetInventoryCommand(_userInterface);
                case "u":
                case "updatequantity":
                    return new UpdateQuantityCommand(_userInterface);
                case "?":
                    return new HelpCommand(_userInterface);
                default:
                    return new UnknownCommand(_userInterface);
            }
        }
    }
}
