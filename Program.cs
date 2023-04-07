using System;

class Processor
{
    public string merk { get; set; }
    public string tipe { get; set; }
}

class Intel : Processor
{
    public Intel()
    {
        merk = "Intel";
    }
}

class Corei3 : Intel
{
    public Corei3()
    {
        tipe = "Core i3";
    }
}

class Corei5 : Intel
{
    public Corei5()
    {
        tipe = "Core i5";
    }
}

class Corei7 : Intel
{
    public Corei7()
    {
        tipe = "Core i7";
    }
}
class AMD : Processor
{
    public AMD()
    {
        merk = "AMD";
    }
}

class Ryzen : AMD
{
    public Ryzen()
    {
        tipe = "RAYZEN";
    }
}

class Athlon : AMD
{
    public Athlon()
    {
        tipe = "ATHLON";
    }
}

class Vga
{
    public string merk { get; set; }
}

class Nvidia : Vga
{
    public Nvidia()
    {
        merk = "Nvidia";
    }
}

class AMD : Vga
{
    public AMD()
    {
        merk = "AMD";
    }
}

class Laptop
{
    public string merk;
    public string tipe;
    public string vga
    {
        get { return vga; }
        set { vga = "Vga"; }
    }

    public string processor
    {
        get { return processor; }
        set { processor = "Processor"; }
    }

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
        merk = "ASUS";
    }
}

class ROG : ASUS
{
    public ROG()
    {
        tipe = "ROG";
    }
}

class Vivobook : ASUS
{
    public Vivobook()
    {
        tipe = "Vivobook";
    }

    public void Ngoding()
    {
        Console.WriteLine($"Ctak Ctak Ctak, error lagi!!");
    }
}

class ACER : Laptop
{
    public ACER()
    {
        merk = "ACER";
    }
}

class Swift : ACER
{
    public Swift()
    {
        tipe = "Swift";
    }
}

class Predator : ACER
{
    public Predator()
    {
        tipe = "Predator";
    }
    public void BermainGame()
    {
        Console.WriteLine($"Laptop {merk} {tipe} sedang memainkan game");
    }
}

class Lenovo : Laptop
{
    public Lenovo()
    {
        merk = "Lenovo";
    }
}

class IdeaPad : Lenovo
{
    public IdeaPad()
    {
        tipe = "IdeaPad";
    }
}

class Legion : Lenovo
{
    public Legion()
    {
        tipe = "Legion";
    }
}

class Program
{
    static void Main(string[] args)
    {
        Laptop laptop1 = new Vivobook();
        laptop1.merk = new ASUS().merk;
        laptop1.tipe = new Vivobook().tipe;
        laptop1.vga = new Nvidia().merk;
        laptop1.processor = new Corei5().tipe;

        Laptop laptop2 = new IdeaPad();
        laptop2.merk = new Lenovo().merk;
        laptop2.tipe = new IdeaPad().tipe;
        laptop2.vga = new AMD().merk;
        laptop2.processor = new Ryzen().tipe;

        Predator predator = new Predator();
        predator.merk = new ACER().merk;
        predator.tipe = new Predator().tipe;
        predator.vga = new AMD().merk;
        predator.processor = new Corei7().tipe;

        Console.WriteLine($"Soal 1");
        laptop2.LaptopDinyalakan();
        laptop2.LaptopDimatikan();

        Console.WriteLine($"\nSoal 2");
        laptop1.Ngoding();

        Console.WriteLine($"\nSoal 3");
        Console.WriteLine($"Merk VGAnya adalah {laptop1.vga}");
        Console.WriteLine($"Merk Processornya adalah {laptop1.processor}");
        Console.WriteLine($"Tipe Processornya adalah {laptop1.tipe}");

        Console.WriteLine($"\nSoal 4");
        predator.BermainGame();

        Console.WriteLine($"\nSoal 5");
        ACER acer = new Predator();
        acer.BermainGame();
    }
}