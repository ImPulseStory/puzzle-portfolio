public class Solution
{
    public static void Main(string[] args)
    {
        // FISRT TASK
        SayHello();
        SayHello();
        SayHello();

        // SECOND TASK

        Greet("Sasha");
        Greet("Yaroslav");
        Greet("Anna");

        // THIRD TASK
        PrintPerson("Anna", 18, "Volgograd");
        PrintPerson("Andrey", 14, "Volgograd");

        // FOURTH TASK

        PrintPersonEx("Anna", 18, "Design");
        PrintPersonEx("Andrey");

        // FIFTH TASK
        Console.WriteLine(Square(5));

        // SIXTH TASK

        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());
        string operation = Console.ReadLine();

        if (operation == "+")
        {
            Console.WriteLine(Add(x, y));
        }
        else if (operation == "-")
        {
            Console.WriteLine(Subtract(x, y));
        }
        else if (operation == "*")
        {
            Console.WriteLine(Multiply(x, y));
        }
        else if (operation == "/")
        {
            Console.WriteLine(Divide(x, y));
        }
        else {
            Console.WriteLine("Invalid operation");
        }

        // SEVENTH TASK
        int counter = 0;
        int IncrementCounter()
        {
            counter++;
            return counter;
        }

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(IncrementCounter());
        }

        // EIGHTH TASK in functions 
    }
    
    // from fifth task
    static int Square(int x)
    {
        return x * x;
    }
    
    // from eight task
    static int MultiplyEx(int a, int b)
    {
        return a * b;
    }

    static int MultiplyEx(int a, int b, int c)
    {
        return a * b * c;
    }
    
    // from sixth task
    static int Add(int x, int y)
    {
        return x + y;
    }

    static int Subtract(int x, int y)
    {
        return x - y;
    }

    static int Multiply(int x, int y)
    {
        return x * y;
    }

    static int Divide(int x, int y)
    {
        return x / y;
    }
    
    // from second task
    static void Greet(string name)
    {
        Console.WriteLine("Hello " + name);
    }
    
    // from fourth task
    static void PrintPersonEx(string name, int age = 18, string hobby = "Not equals")
    {
        Console.WriteLine($"Hello {name} with age {age} and hobby {hobby}");
    }
    
    // from third task
    static void PrintPerson(string name, int age, string city)
    {
        Console.WriteLine($"Hello {name} with age {age} and city {city}");
    }
    
    // from first task
    static void SayHello()
    {
        Console.WriteLine("Hello world");
    }
}