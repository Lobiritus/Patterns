﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    internal class Detailer :ServiceHandler
    {
        public Detailer() : base(ServiceRequirements.Dirty) { }
    }
}
