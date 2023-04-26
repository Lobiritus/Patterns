using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    [Flags]
    enum ServiceRequirements
    {
        None = 0,
        WheelAlignment = 1,
        Dirty = 2,
        EngineTune = 4,
        TestDrive = 8
    }

    abstract class ServiceHandler
    {
        protected ServiceHandler _nextServiceHandler;
        protected ServiceRequirements _serviceProvided;

        public ServiceHandler(ServiceRequirements servicesProvided)
        {
            _serviceProvided = servicesProvided;
        }

        public void Service(Car car)
        {
            if(_serviceProvided == (car.Requirements & _serviceProvided))
            {
                Console.WriteLine($"{this.GetType().Name} providing {this._serviceProvided} service");
                car.Requirements &= ~_serviceProvided;
            }
            if (car.IsServiceComplete || _nextServiceHandler == null)
                return;
            else
                _nextServiceHandler.Service(car);
        }

        public void SetNextServiceHandler(ServiceHandler handler)
        {
            _nextServiceHandler = handler;
        }
    }
}
