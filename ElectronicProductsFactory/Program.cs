using ElectronicProductsFactory.Clases.Factory;
using ElectronicProductsFactory.Interfaces;

int choice = 0;
Console.WriteLine("¡Hola! ¿Que deseas hoy?");
Console.WriteLine("1.Computadora Portátil \n2. Teléfono Celular \nIngrese número:");
try 
{ 
    choice = int.Parse(Console.ReadLine()); 
}
catch(Exception e)
{
    Console.WriteLine(e.Message);
}
if (choice == 1)
{
    Console.WriteLine("Qué marca deseas escoger? \n1.Apple \n2.Google");
    int laptop = int.Parse(Console.ReadLine());
    if(laptop == 1)
    {
        AppleFactory factoryManzanita = AppleFactory.GetInstance();
        ILaptop seraMac = factoryManzanita.CreateLaptop();
        Console.WriteLine("Felicidades tienes un MacBook: " + seraMac.turnOn());
    } else if(laptop == 2)
    {
        GoogleFactory googleFactory = GoogleFactory.GetInstance();
        ILaptop seraChromebook = googleFactory.CreateLaptop();
        Console.WriteLine("Felicidades tienes un Chromebook: " + seraChromebook.turnOn());
    }
} else if (choice == 2)
{
    Console.WriteLine("Qué marca deseas escoger? \n1.Apple \n2.Google");
    int smartphone = int.Parse(Console.ReadLine());
    if(smartphone == 1)
    {
        AppleFactory factoryApple = AppleFactory.GetInstance();
        ISmartphone createIphone = factoryApple.CreateSmartphone();
        Console.WriteLine("Felicidades tienes un Iphone:" + createIphone.turnOn());
    } else if (smartphone == 2)
    {
        GoogleFactory factoryGoogle = GoogleFactory.GetInstance();
        ISmartphone createPixel = factoryGoogle.CreateSmartphone();
        Console.WriteLine("Felicidades tienes un pixel:" + createPixel.turnOn());
    }
}
