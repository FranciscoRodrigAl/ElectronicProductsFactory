using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicProductsFactory.Interfaces
{
    internal interface IElectronicProductsFactory
    {
        ISmartphone CreateSmartphone();

        ILaptop CreateLaptop();
    }
}
