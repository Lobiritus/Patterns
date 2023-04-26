using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ObserverPattern.Subject;

namespace ObserverPattern
{
    public delegate void QuantityUpdated(int quantity);
    internal class Subject
    {

        public event QuantityUpdated OnQuantityUpdated;

        private int _quantity = 0;
        public void UpdateQuantity(int value)
        {
            _quantity += value;

            OnQuantityUpdated?.Invoke(_quantity);
        }
    }
}
