//Nama  : Mita Nurul Azizah
//NIM   : 222410102076
//Kelas : PBO A
//Modul 3

using System;
class Processor
{
    public string merk;
    public string tipe;
}
class Intel : Processor
{
    public Intel()
    {
        base.merk = "Intel";
    }
}
class AMD : Processor
{
    public AMD()
    {
        base.merk = "AMD";
    }
}
class CoreI3 : Intel
{
    public CoreI3()
    {
        base.tipe = "Core i3";
    }
}
class CoreI5 : Intel
{
    public CoreI5()
    {
        base.tipe = "Core i5";
    }
}
class CoreI7 : Intel
{
    public CoreI7()
    {
        base.tipe = "Core i7";
    }
}
class Ryzen : AMD
{
    public Ryzen()
    {
        base.tipe = "RAYZEN";
    }
}
class ATHLON : AMD
{
    public ATHLON()
    {
        base.tipe = "ATHLON";
    }
}
class VGA
{
    public string merk;
}
class Nvidia : VGA
{
    public Nvidia()
    {
        base.merk = "Nvidia";
    }
}
class amd : VGA
{
    public amd()
    {
        base.merk = "AMD";
    }
}

class Laptop
{
    public string merk;
    public string tipe;
    public VGA vga;
    public Processor processor;

    public void LaptopDinyalakan()
    {
        Console.WriteLine($"Laptop {merk} {tipe} menyala");
    }
    public void LaptopDimatikan()
    {
        Console.WriteLine($"Laptop {merk} {tipe} mati");
    }
}
class ASUS : Laptop
{
    public ASUS()
    {
        base.merk = "ASUS";
    }
}
class ACER : Laptop
{
    public ACER()
    {
        base.merk = "ACER";
    }
}
class Lenovo : Laptop
{
    public Lenovo()
    {
        base.merk = "Lenovo";
    }
}
class ROG : ASUS
{
    public ROG()
    {
        base.tipe = "ROG";
    }
}
class Vivobook : ASUS
{
    public Vivobook()
    {
        base.tipe = "Vivobook";
    }
    public void Ngoding()
    {
        Console.WriteLine("Ctak Ctak Ctak, error lagi!!");
    }
}
class Swift : ACER
{
    public Swift()
    {
        base.tipe = "Swift";
    }
}
class Predator : ACER
{
    public Predator()
    {
        base.tipe = "Predator";
    }
    public void BermainGame()
    {
        Console.WriteLine($"Laptop {merk} {tipe} sedang memainkan game");
    }
}
class IdeaPad : Lenovo
{
    public IdeaPad()
    {
        base.tipe = "IdeaPad";
    }
}
class Legion : Lenovo
{
    public Legion()
    {
        base.tipe = "Legion";
    }
}
internal class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("==========Laptop 1==========");
        Laptop laptop1 = new Vivobook();
        laptop1.vga = new Nvidia();
        laptop1.processor = new CoreI5();

        Console.WriteLine("Vga              : " + laptop1.vga.merk);
        Console.WriteLine("Merk Prosessor   : " + laptop1.processor.merk);
        Console.WriteLine("Tipe Prosessor   : " + laptop1.processor.tipe);
        //laptop1.Ngoding(); //Tidak bisa
        Console.WriteLine("\n");

        Console.WriteLine("==========Laptop 2==========");
        Laptop laptop2 = new IdeaPad();
        laptop2.vga = new amd();
        laptop2.processor = new Ryzen();

        Console.WriteLine("Vga              : " + laptop2.vga.merk);
        Console.WriteLine("Merk Prosessor   : " + laptop2.processor.merk);
        Console.WriteLine("Tipe Prosessor   : " + laptop2.processor.tipe);
        laptop2.LaptopDinyalakan();
        laptop2.LaptopDimatikan();
        Console.WriteLine("\n");

        Console.WriteLine("==========Predator==========");
        Predator predator = new Predator();
        predator.vga = new amd();
        predator.processor = new CoreI7();

        Console.WriteLine("Vga              : " + predator.vga.merk);
        Console.WriteLine("Merk Prosessor   : " + predator.processor.merk);
        Console.WriteLine("Tipe Prosessor   : " + predator.processor.tipe);
        predator.BermainGame();
        Console.WriteLine("\n");

        ACER acer = new Predator();
        //acer.BermainGame();

        Console.WriteLine("==========Ngoding==========");
        Vivobook ngoding1 = new Vivobook();
        ngoding1.vga = new Nvidia();
        ngoding1.processor = new Ryzen();
        ngoding1.Ngoding();
        //ini merupakan konstruktor supaya method ngoding berjalan
    }
}