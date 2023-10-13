class Program
{
	static void Main()
	{
		// Var = decide on compile time
		var x = 3;
		x = int.Parse("22");
		Console.WriteLine(x);
		
		// Object = decide on runtime
		int y = 3;
		object y1 = y; //unboxing
		int y2 = (int)y1;
		Console.WriteLine(y);
		Console.WriteLine(y1);
		Console.WriteLine(y2);
		
		Printer(2);
		Printer("33aa");
		
		Add(2,5);
		Add("3","5");
		
		//Dynamic = decide on runtime without error checking
		dynamic d1 = 3;
		Console.WriteLine(d1);
		d1 = "a3";
		Console.WriteLine(d1);
		//d1.Runtime(); //Tanpa Error padahal seharusnya tidak bisa tercompile
		
	}
	static void Printer(object x)
	{
		Console.WriteLine(x);
	}
	
	static void Add(object a, object b)
	{
		if (a is int && b is int)
		{
			Console.WriteLine((int)a+(int)b);
		}
		else
		{
			Console.WriteLine("Error");
		}
	}
} 

