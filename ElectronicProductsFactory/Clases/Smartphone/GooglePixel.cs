using ElectronicProductsFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicProductsFactory.Clases.Smartphone
{
    internal class GooglePixel : ISmartphone
    {
        public string turnOff()
        {
            return "turning off Google Pixel";
        }

        public string turnOn()
        {
            return "turning on Google Pixel";
        }

        public string rechargingConnector()
        {
            return "uses USB-C";
        }
    }
}
