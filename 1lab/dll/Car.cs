namespace dll;

public class Machine
{
    public string Metal = "None";
    public int Age = 0;
    public bool Break = false;

    /*public Machine CreateMachine()*/
    /*{*/
    /**/
    /*    Console.WriteLine("Metal: ");*/
    /*    string metal = Console.ReadLine();*/
    /*    Console.WriteLine("Age: ");*/
    /*    int age = int.Parse(Console.ReadLine());*/
    /*    Console.WriteLine("Break: ");*/
    /*    bool break_ = bool.Parse(Console.ReadLine());*/
    /**/
    /**/
    /*    return new Machine { Metal = metal, Age = age, Break = break_ };*/
    /*}*/


    public void Repair()
    {
        if (Break)
        {
            Break = false;
            Console.WriteLine("Машина исправлена");
        }

        else
            Console.WriteLine("Машина в хорошем состоянии");

    }

    public void setAge(int new_age)
    {
        Age = new_age;
        Console.WriteLine($"Set age: {Age}");
    }

    public void ShowInfo()
    {
        string Status = Checking();
        Console.WriteLine($"\nMachine age: {Age}\nStatus: {Status}\nMetal: {Metal}");
    }

    public string Checking()
    {
        if (!Break)
            return "serviceable";
        else
            return "break";
    }
}

public class Car : Machine
{
    public string Model = "None";
    public int Places = 0;
    public Engine engine = new Engine();
    public bool Drive = false;

    public void DriveToggle()
    {
        if (Drive) { Drive = false; }
        else { Drive = true; }

        if (Drive && !Break)
        {


            if (!engine.Work)
            {
                engine.Start();
            }

            Console.WriteLine("Drive");
        }

        else if (Break)
        {
            Drive = false;
            Console.WriteLine("Car is broken!");
        }
        else
        {
            if (engine.Work)
            {
                engine.Stop();
            }
            Console.WriteLine("Stop drive");
        }
    }

    public void Honk() { Console.WriteLine("HONK!"); }

    public void ReplaceEngine()
    {
        if (engine.Work) { engine.Stop(); }

        Console.WriteLine("Model engine: ");
        string? model = Console.ReadLine();

        Console.WriteLine("Cylinders engine: ");
        int cylinders = int.Parse(Console.ReadLine());

        Console.WriteLine("HorsePower engine: ");
        int horse_power = int.Parse(Console.ReadLine());

        Engine new_engine = new Engine { model_engine = model, Cylinders = cylinders, HorsePower = horse_power };
        engine = new_engine;

    }

    public void modelEngine()
    {
        Console.WriteLine(engine.model_engine);

    }

    public Car CreateCar()
    {


        Car newCar = new Car();

        Console.WriteLine("Model: ");
        newCar.Model = Console.ReadLine();

        Console.WriteLine("Places: ");
        newCar.Places = int.Parse(Console.ReadLine());

        Console.WriteLine("--Machine Properties--");
        Console.WriteLine("Metal: ");
        newCar.Metal = Console.ReadLine();

        Console.WriteLine("Age: ");
        newCar.Age = int.Parse(Console.ReadLine());

        Console.WriteLine("Break (true/false): ");
        newCar.Break = bool.Parse(Console.ReadLine());

        Console.WriteLine("--Engine Properties--");
        /*newCar.engine = new Engine();*/
        newCar.engine.createEngine();

        return newCar;

    }

}

public class Engine
{
    public string? model_engine = "None";
    public int Cylinders = 0;
    public int HorsePower = 0;
    public bool Work = false;

    public Engine createEngine()
    {

        Console.WriteLine("Model: ");
        string Model_engine = Console.ReadLine();
        Console.WriteLine("Cylinders: ");
        int cylinders = int.Parse(Console.ReadLine());
        Console.WriteLine("HorsePower: ");
        int horsePower = int.Parse(Console.ReadLine());

        return new Engine { Cylinders = Cylinders, HorsePower = horsePower, model_engine = Model_engine };
    }

    public void Start()
    {
        if (!Work) { Work = true; } else { Console.WriteLine("The engine is already running"); }
    }

    public void Stop()
    {
        if (Work) { Work = false; } else { Console.WriteLine("The engine is no longer running"); }
    }


    public void Upgrade(int extraHorsPower)
    {
        HorsePower = extraHorsPower;
    }

}
