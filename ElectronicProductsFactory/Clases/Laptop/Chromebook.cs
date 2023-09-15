using ElectronicProductsFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicProductsFactory.Clases.Laptop
{
    internal class Chromebook : ILaptop
    {

        public string turnOff()
        {
            return "turning off Chromebook";
        }

        public string turnOn()
        {
            return "turnin on Chromebook";
        }
    }
}
