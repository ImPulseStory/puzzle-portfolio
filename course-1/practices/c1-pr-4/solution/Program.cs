namespace DefaultNamespace;

public class Program
{
    public static void Main(string[] args)
    {
        // FIRST TASK
        int number = 10;
        if (number > 0)
        {
            Console.WriteLine("Число положительное"); 
        }
        else if (number < 0)
        {
            Console.WriteLine("Число отрицательное");
        }
        else if (number == 0)
        {
            Console.WriteLine("Число равно 0");
        }
        
        // SECOND TASK
        string inp = Console.ReadLine();
        int age = int.Parse(inp);
        if (age < 18)
        {
            Console.WriteLine("Вы несовершеннолетний");
        }
        else
        {
            Console.WriteLine("Вы совершеннолетний");
        }
        
        // THIRD TASK
        int num = 7;
        if (num % 2 == 0)
        {
            Console.WriteLine("Число четное");
        }
        else
        {
            Console.WriteLine("Число нечетное");
        }
        
        // FOURTH TASK
        int a = 5;
        int b = -2;

        if (a > 0 && b > 0)
        {
            Console.WriteLine("Оба числа положительные");
        }

        else if (a > 0 || b > 0)
        {
            Console.WriteLine("Одно число положительное");
        }
        else if (a < 0)
        {
            Console.WriteLine("Число а не положиьтельное");
        }
        
        // FIFTH TASK
        string inpu = Console.ReadLine();
        int grade =  int.Parse(inpu);

        if (grade < 3)
        {
            Console.WriteLine("Неудолетворительно");
        }
        else if (grade == 3)
        {
            Console.WriteLine("Удолетворительно");
        }
        else if (grade == 4)
        {
            Console.WriteLine("Хорошо");
        }
        else if (grade == 5)
        {
            Console.WriteLine("Отлично!");
        }
    }
}