using dll;

class Program
{
    static public void Main()
    {
        bool exit = false;

        do
        {
            Console.Clear();
            Console.WriteLine("1. Create car");
            Console.WriteLine("2. Info car");
            Console.WriteLine("0. Exit");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Car newCar = new Car();
                    newCar.CreateCar();
                    break;
                case 0:
                    exit = true;
                    Console.Clear();
                    break;
            }

        } while (!exit);
    }
}

