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
    internal class GoogleFactory : IElectronicProductsFactory
    {
        private static GoogleFactory instance;

        private GoogleFactory() { }

        public static GoogleFactory GetInstance()
        {
            if(instance == null)
            {
                instance = new GoogleFactory();
            }
            return instance;
        }
        public ILaptop CreateLaptop()
        {
            return new Chromebook();
        }

        public ISmartphone CreateSmartphone()
        {
            return new GooglePixel();
        }
    }
}
