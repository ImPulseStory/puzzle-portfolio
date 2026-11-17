public class Car
{
	private string brand;
	private int speed;
	
	public Car(string brand, int speed)
	{
		this.brand = brand;
		this.speed = speed;
	}

	public void accelerate()
	{
		this.speed += 10;
	}
	
	public override string ToString()
	{
		return $"Автомобиль {this.brand} едет со скоростью {this.speed}";
	}

	public string getBrand()
	{
		return this.brand;
	}

	public int getSpeed()
	{
		return this.speed;
	}
}

public class Book
{
	private string title;
	private string author;
	private int pages;
	
	public Book(string title, string author, int pages)
	{
		this.title = title;
		this.author = author;
		this.pages = pages;
	}

	public void Read(int pages)
	{
		if (pages >= this.pages)
		{
			Console.WriteLine("В книге меньше страниц!");
		}
		else
		{
			Console.WriteLine($"Вы прочитали {pages} страниц из {this.pages}");
		}
	}
	
	public string getTitle()
	{
		return this.title;
	}

	public string getAuthor()
	{
		return this.author;
	}

	public int getPages()
	{
		return this.pages;
	}
}

public class Library
{
	private List<Book> books = new List<Book>();
	
	public Library()
	{}

	public void AddBook(Book book)
	{
		this.books.Add(book);
	}
	
	public void PrintAllBooks()
	{
		foreach (Book book in this.books)
		{
			Console.WriteLine(book.getTitle());
			Console.WriteLine(book.getAuthor());
			Console.WriteLine(book.getPages());
		}
	}
}

public class Program
{
	public static void Main(String[] args)
	{
		// FISRT TASK
		var car = new Car("BMW", 220);
		car.accelerate();
		Console.WriteLine(car.ToString());
		
		// SECOND TASK
		var book = new Book("Война и мир", "Л.Н Толстой", 570);
		book.Read(360);
		
		// THIRD TASK
		var lib = new Library();
		lib.AddBook(book);
		lib.AddBook(book);
		lib.PrintAllBooks();
	}
}