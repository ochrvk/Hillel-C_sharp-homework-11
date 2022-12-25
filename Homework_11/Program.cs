using System.Drawing;

class Cat
{
    public Cat()
    {
        name = "";
        catOwnerName = "";
        id = Guid.NewGuid();

    }

    //name can be anything, verification is not needed 
    //1
    public string name;
    //2
    public string catOwnerName;
    //3
    private int age;
    //4
    private int weight;
    //5
    private int height;
    //6
    private Guid id;
    //7
    private string color;

    //no set because this filed must calculate it
    //8
    bool IsHealth
    {
        get
        {
            return (weight >= 4 && weight <= 5) && (height >= 23 && height <= 25);
        }
    }

    public int Age
    {
        get
        {
            return age;
        }

        set
        {
            if (value > 0 && value < 18)
            {
                age = value;
            }
            else
            {
                throw new Exception("Impossible");
            }
        }

    }

    public int Weight
    {
        get { return weight; }
        set
        {
            if (value < 5 && value > 0)
            {
                weight = value;
            }
            else
            {
                throw new Exception("Impossible weight");
            }
        }
    }

    public int Height
    {
        get { return height; }
        set
        {
            if (value < 25 && value > 0)
            {
                height = value;
            }
            else
            {
                throw new Exception("impossible height");
            }
        }
    }

    public string Color
    {
        get { return color; }
        set
        {

            if (value == "White" || value == "Black" || value == "Ginger")
            {
                color = value;
            }
            else
            {
                throw new Exception("Incorrect color");
            }
        }
    }

    public Guid ID
    {
        get { return id; }
    }


    public override string ToString()
    {
        return $"Name: {name}\nColor: {color}\nAge: {Age}\nWeight: {weight}\nHeight: {height}\n" +
            $"ID: {id}\nHealth status: {IsHealth}\nCat Owner: {catOwnerName}";
    }
}
class Laptop
{
    public Laptop()
    {
        id = Guid.NewGuid();
        modelName = "";
        cpuName = "";
        gpuName = "";
    }

    //1
    private Guid id;
    //2
    private int ramAmount;
    //3
    private int year;
    //3
    public bool b_a;
    //4
    public string modelName;
    //5
    public string cpuName;
    //6
    public string gpuName;
    //7
    public string Windows
    {
        get
        {
            if (year > 2017)
            {
                return "win11";
            }
            else
            {
                return "win7/8/10";
            }
        }
    }

    public int RamAmount
    {
        get { return ramAmount; }
        set
        {
            //there no laptops with RAM less than 4 and higher than 128 in my imaginary store
            if (value > 4 && value < 128)
            {
                ramAmount = value;
            }
            else
            {
                throw new Exception("Incorrect value");
            }
        }
    }

    public int Year
    {
        get { return year; }
        set
        {
            if (value > 2004 && value < 2022)
            {
                year = value;
            }
            else
            {
                throw new Exception("Incorrect value");
            }
        }
    }

    public override string ToString()
    {
        return $"ID: {id}\nRAM: {ramAmount}\nYear: {year}\nB\\A: {b_a}\nModel: {modelName}\nCPU: {cpuName}\nGPU: {gpuName}\nWindows: {Windows}";
    }
}
class Headphones
{
    public Headphones()
    {
        id = Guid.NewGuid();
        name = "";
        wireless = false;
    }

    //1
    private Guid id;
    //2
    private string connectionType;
    //3
    private int cableLengh;
    //4
    public string name;
    //5
    public bool wireless;
    //6
    private string soundChanel;
    //7
    public bool BuiltInSoundCard
    {
        get
        {
            if (connectionType == "usb")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    public string ConnectionType
    {
        get { return connectionType; }
        set
        {
            if (value == "usb" || value == "mini jack")
            {
                connectionType = value;
            }
            else
            {
                throw new Exception("Incorrect type!");
            }
        }
    }

    public int CableLengh
    {
        get { return cableLengh; }
        set
        {
            if (value > 0 && value < 3)
            {
                cableLengh = 3;
            }
            else
            {
                throw new Exception("Incorrect length");
            }
        }

    }

    public string SoundChanel
    {
        get { return soundChanel; }
        set
        {
            if (value == "mono" || value == "stereo")
            {
                soundChanel = value;
            }
            else
            {
                throw new Exception("Incorrect value");
            }
        }
    }

    public override string ToString()
    {
        return $"ID: {id}\nConnection Type: {connectionType}\nCable lengh: {cableLengh}\n" +
            $"Name: {name}\nWireless support: {wireless}\nSound channel: {soundChanel}\nBuild-in sound card: {BuiltInSoundCard}";
    }
}
class Program
{
    static void InputCat(Cat cat)
    {
        Console.Write("Please type cat name: ");
        cat.name = Console.ReadLine();

        Console.Write("Please type owner name: ");
        cat.catOwnerName = Console.ReadLine();

        Console.Write("Please type cat age: ");
        while (true)
        {
            try
            {
                cat.Age = int.Parse(Console.ReadLine()); break;
            }

            catch (Exception)
            {
                Console.WriteLine("Wrong age! Please try again: ");
            }
        }

        Console.Write("Please type cat weight: ");
        while (true)
        {
            try
            {
                cat.Weight = int.Parse(Console.ReadLine()); break;
            }

            catch (Exception)
            {
                Console.WriteLine("Wrong weight! Please try again: ");
            }
        }

        Console.Write("Please type cat height: ");
        while (true)
        {
            try
            {
                cat.Height = int.Parse(Console.ReadLine()); break;
            }

            catch (Exception)
            {
                Console.WriteLine("Wrong height! Please try again: ");
            }
        }

        Console.Write("Please type cat color: ");
        while (true)
        {
            try
            {
                cat.Color = Console.ReadLine();
                break;
            }

            catch (Exception)
            {
                Console.WriteLine("Wrong color! Please try again: ");
            }
        }
    }

    static void InputLaptop(Laptop laptop)
    {
        Console.Write("Please type model name: ");
        laptop.modelName = Console.ReadLine();

        Console.Write("Please type CPU name: ");
        laptop.cpuName = Console.ReadLine();

        Console.Write("Please type GPU name: ");
        laptop.gpuName = Console.ReadLine();

        Console.Write("Please type RAM amount: ");
        while (true)
        {
            try
            {
                laptop.RamAmount = int.Parse(Console.ReadLine());
                break;
            }
            catch (Exception)
            {
                Console.WriteLine("Wrong input, please try again: ");
            }
        }


        Console.Write("Please type year of production: ");
        while (true)
        {
            try
            {
                laptop.Year = int.Parse(Console.ReadLine());
                break;
            }
            catch (Exception)
            {
                Console.WriteLine("Wrong input, please try again: ");
            }
        }

        Console.WriteLine("Is this computer new or has it been used?");
        while (true)
        {
            try
            {
                laptop.b_a = bool.Parse(Console.ReadLine());
                break;
            }
            catch (Exception)
            {
                Console.WriteLine("Wrong input, please try again: ");
            }
        }

    }

    static void InputHeadphones(Headphones headphones)
    {
        Console.Write("Please type headphone name: ");
        headphones.name = Console.ReadLine();

        Console.Write("Please type connection type: ");
        while (true)
        {
            try
            {
                headphones.ConnectionType = Console.ReadLine();
                break;
            }
            catch (Exception)
            {
                Console.WriteLine("Wrong input, please try again: ");
            }
        }

        Console.Write("Please type cable lenght: ");
        while (true)
        {
            try
            {
                headphones.CableLengh = int.Parse(Console.ReadLine());
                break;
            }
            catch (Exception)
            {
                Console.WriteLine("Wrong input, please try again: ");
            }
        }

        Console.Write("Do these headphones support wireless connectivity?: ");
        while (true)
        {
            try
            {
                headphones.wireless = bool.Parse(Console.ReadLine());
                break;
            }
            catch (Exception)
            {
                Console.WriteLine("Wrong input, please try again: ");
            }
        }

        Console.Write("Please type sound chanel: ");
        while (true)
        {
            try
            {
                headphones.SoundChanel = Console.ReadLine();
                break;
            }
            catch (Exception)
            {
                Console.WriteLine("Wrong input, please try again: ");
            }
        }
    }

    static void Main(string[] args)
    {
        Laptop laptop = new Laptop();
        Cat cat = new Cat();
        Headphones headphones = new Headphones();

        InputCat(cat);
        Console.Clear();
        InputLaptop(laptop);
        Console.Clear();
        InputHeadphones(headphones);
        Console.Clear();

        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine(laptop);
        Console.WriteLine("---------");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(cat);
        Console.WriteLine("---------");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(headphones);
        Console.ForegroundColor = ConsoleColor.White;
    }
}