class Program
{
	static void Main()
	{
		Car mobil = new();
		
		//Encapsulation
		mobil.age = 9;
		mobil.SetWheel(3);
		int wheelvalue = mobil.GetWheel("password");
		Console.WriteLine(wheelvalue);

		mobil.Move();
		// mobil.Jump();
		// mobil.Turbo();
		// mobil.door = 9;
		
		//Property
		mobil.SetWindow(9);
		Console.WriteLine(mobil.Window);
		
		mobil.Balance = 2;
	}
}

class Car
{
	//Encapsulation
	public int age;
	private int _wheel;
	// protected int door;
	
	//Property
	public int Window{get; private set;}
	public void SetWindow(int window)
	{
		this.Window = window; 
	}
	
	private int _balance = 1;
	public int Balance
	{
		get
		{
			return _balance;
		}
		set
		{
			if(value>0)
			{
				_balance = value;
			}
		}
	}
	
	public void SetWheel(int wheel)
	{
		_wheel = wheel;
	}
	public int GetWheel(string password)
	{
		if (password=="password")
		{
			return _wheel;
		}
		else
		{
			return 0;
		}
	}
	
	public void Move()
	{
		Console.WriteLine("Move");
	}
	private void Jump()
	{
		Console.WriteLine("Jump");
	}
	private void Turbo()
	{
		Console.WriteLine("Turbo");
	}
}