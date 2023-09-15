using ElectronicProductsFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicProductsFactory.Clases.Smartphone
{
    internal class IPhone : ISmartphone
    {
        public string turnOff()
        {
            return "turning off Iphone";
        }

        public string turnOn()
        {
            return "turning on Iphone";
        }
        public string rechargingConnector()
        {
            return "uses Lightning";
        }
    }
}
