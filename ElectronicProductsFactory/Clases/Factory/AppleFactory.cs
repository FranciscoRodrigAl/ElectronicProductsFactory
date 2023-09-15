using ElectronicProductsFactory.Clases.Laptop;
using ElectronicProductsFactory.Clases.Smartphone;
using ElectronicProductsFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicProductsFactory.Clases.Factory
{
    internal class AppleFactory : IElectronicProductsFactory
    {
        private static AppleFactory instance;
        private AppleFactory() { }
        public static AppleFactory GetInstance()
        {
            if(instance == null)
            {
                instance = new AppleFactory();
            }
            return instance;
        }

        public ILaptop CreateLaptop()
        {
            return new Macbook();
        }

        public ISmartphone CreateSmartphone()
        {
            return new IPhone();
        }
    }
}
