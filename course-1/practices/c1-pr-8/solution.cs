public class Book
{
	private string Title;
	private string Author;
	private int pages;

	public Book()
	{
		this.Title = "";
		this.Author = "";
		this.pages = 0;
	}

	public Book(string title)
	{
		this.Title = title;
		this.Author = "";
		this.pages = 0;
	}
	
	public Book(string title, string author)
	{
		this.Title = title;
		this.Author = author;
		this.pages = 0;
	}
	
	public Book(string title, string author, int pages)
	{
		this.Title = title;
		this.Author = author;
		this.pages = pages;
	}

	public void PrintInfo()
	{
		Console.WriteLine(this.Title);
		Console.WriteLine(this.Author);
		Console.WriteLine(this.pages);
	}
}

public class Car
{
	private string brand;	
	private string model;
	private int speed;

	public Car(string brand, string model, int speed)
	{
		this.brand = brand;
		this.model = model;
		this.speed = speed;
	}

	public Car() : this(null, null, 0)
	{
		
	}
	
	public Car(string brand) : this(brand, null, 0) { }
	
	public Car(string brand, string model) : this(brand, null, 0) { }
}

public class Player
{
	private string name;
	private int level;
	
	public Player(string name, int level)
	{
		this.name = name;
		this.level = level;
	}
	
	public void PrintInfo()
	{
		Console.WriteLine(this.name);
		Console.WriteLine(this.level);
	}
}

public class User
{
	private string name;
	private string password;

	public User(string name, string password)
	{
		this.name = name;
		this.password = password;
	}
	
	public void SetPassword(string password)
	{
		if (password == "")
		{
			Console.WriteLine("Парль не должен быть пустым!");
		}
		else
		{
			this.password = password;
		}
	}

	public void CheckPassword(string password)
	{
		if (password == this.password)
		{
			Console.WriteLine("Correct!");
		}
	}
}

public class Program
{
	public static void Main(string[] args)
	{
		// 1 TASK
		var b1 = new Book();
		var b2 = new Book("1984");
		var b3 = new Book("Гарри Поттер", "Дж. Роулинг", 500);

		b1.PrintInfo();
		b2.PrintInfo();
		b3.PrintInfo();
		
		// 3 TASK
		var p1 = new Player("Alex", 5);
		var p2 = new Player("Alex", 5);
		var p3 = p1;

		Console.WriteLine(p1 == p2); 
		Console.WriteLine(p1 == p3);
		Console.WriteLine(p1.Equals(p2)); 
		
		// 4 TASK
		var user = new User("Alex", "password");
		user.CheckPassword("password");
		user.SetPassword("");
	}
}