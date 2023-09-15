using ElectronicProductsFactory.Clases.Factory;
using ElectronicProductsFactory.Interfaces;

AppleFactory factoryManzanita =  AppleFactory.GetInstance();
GoogleFactory factoryGoogleA = GoogleFactory.GetInstance();
GoogleFactory factorygoogleB = GoogleFactory.GetInstance();
ILaptop seraMac = factoryManzanita.CreateLaptop();
ILaptop seraChromebook = factoryGoogleA.CreateLaptop();
Console.WriteLine("la cosa instanciada: "+seraMac.turnOn());
Console.WriteLine("la cosa instanciada: "+seraChromebook.turnOn());

if(factoryGoogleA == factorygoogleB)
{
    Console.WriteLine("Funciona el singleton");
}
else
{
    Console.WriteLine("No funciona el singleton");
}