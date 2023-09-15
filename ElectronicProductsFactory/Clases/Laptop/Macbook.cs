using ElectronicProductsFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicProductsFactory.Clases.Laptop
{
    internal class Macbook : ILaptop
    {
        public string turnOff()
        {
            return "turning off Macbook";
        }

        public string turnOn()
        {
            return "turning on Macbook";
        }
    }
}
