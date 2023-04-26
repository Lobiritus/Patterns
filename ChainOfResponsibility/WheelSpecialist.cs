using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    internal class WheelSpecialist : ServiceHandler
    {
        public WheelSpecialist() : base(ServiceRequirements.TestDrive) { }
    }
}
