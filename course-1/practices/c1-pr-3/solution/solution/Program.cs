// See https://aka.ms/new-console-template for more information

// 1 task

int a = 12;
int b = 5;

int c = a + b;
c = a - b;
c = a * b;
c = a / b;

// 2 TASK

Console.Write("Enter your name: ");
string name = Console.ReadLine();
Console.WriteLine($"Hello {name}!");

// 3 task

Console.Write("enter a: ");
string aa =  Console.ReadLine();
int aaa = int.Parse(aa);
Console.Write("enter b: ");
string bb =  Console.ReadLine();
int bbb = int.Parse(bb);
Console.WriteLine($"sum : {aa + bbb}");

// 5 task

Console.Write("Enter temp: ");
string temp = Console.ReadLine();
int temp1 = int.Parse(temp);
Console.WriteLine($"temp F : {temp1 * 9 / 5 + 32}");

// 4 task

Console.Write("Enter width: ");
string width = Console.ReadLine();
int width1 = int.Parse(width);
Console.Write("Enter height: ");
string height = Console.ReadLine();
int height1 = int.Parse(height);
Console.WriteLine($"squares : {width1 * height1}");

// 6 task

Console.Write("Enter first number: ");
string firstNumber = Console.ReadLine();
int firstNumber1 = int.Parse(firstNumber);
Console.Write("Enter second number: ");
string secondNumber = Console.ReadLine();
int secondNumber1 = int.Parse(secondNumber);
Console.Write("Enter third number: ");
string thirdNumber = Console.ReadLine();
int thirdNumber1 = int.Parse(thirdNumber);
Console.WriteLine($"sum : {(firstNumber1 + secondNumber1 + thirdNumber1) / 3}");

// 7 task

Console.Write("Enter 1 number: ");
string number = Console.ReadLine();
int number1 = int.Parse(number);
Console.Write("Enter 2 number: ");
string number2 = Console.ReadLine();
int number21 = int.Parse(number2);

Console.WriteLine($"sum:  {number1 + number21}");
Console.WriteLine($"разность: {number1 - number21}");
Console.WriteLine($"произведение: {number1 * number21}");
Console.WriteLine($"частное: {number1 / number21}");