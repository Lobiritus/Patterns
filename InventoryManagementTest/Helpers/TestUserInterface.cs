using InventoryManagement.UserInterface;
using NuGet.Frameworks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementTest.Helpers
{
    class TestUserInterface : IUserInterface
    {
        private readonly List<Tuple<string, string>> _expectedReadRequests;
        private readonly List<string> _expectedWriteMessageRequests;
        private readonly List<string> _expectedWriteWarningRequests;

        private int _expectedReadRequestsIndex;
        private int _expectedWriteMessageRequestsIndex;
        private int _expectedWriteWarningRequestsIndex;

        public TestUserInterface(List<Tuple<string,string>> expectedReadRequests,List<string> expectedWriteRequests, List<string> expectedWarningRequests)
        {
            _expectedReadRequests = expectedReadRequests;
            _expectedWriteMessageRequests = expectedWriteRequests;
            _expectedWriteWarningRequests = expectedWarningRequests;
        }
        
        public string ReadValue(string message)
        {
            Assert.True(_expectedWriteWarningRequestsIndex < _expectedWriteWarningRequests.Count, "Received too many command write warning requests");

            Assert.Equal(_expectedWriteWarningRequests[_expectedWriteWarningRequestsIndex++], message);

            return _expectedReadRequests[_expectedReadRequestsIndex++].Item2;
        }

        
        public void WriteMessage(string message)
        {
            Assert.True(_expectedWriteMessageRequestsIndex < _expectedWriteMessageRequests.Count,
                "Received too many command write message requests.");

            Assert.Equal(_expectedWriteMessageRequests[_expectedWriteMessageRequestsIndex++], message);
        }

        
        public void WriteWarning(string message)
        {
            Assert.True(_expectedWriteWarningRequestsIndex < _expectedWriteWarningRequests.Count,
                "Received too many command write warning requests.");

            Assert.Equal(_expectedWriteWarningRequests[_expectedWriteWarningRequestsIndex++], message);
        }

        
        public void Validate()
        {
            Assert.True(_expectedReadRequestsIndex == _expectedReadRequests.Count, "Not all read requests were performed.");
            Assert.True(_expectedWriteMessageRequestsIndex == _expectedWriteMessageRequests.Count, "Not all write requests were performed.");
            Assert.True(_expectedWriteWarningRequestsIndex == _expectedWriteWarningRequests.Count, "Not all warning requests were performed.");
        }
    }
}
