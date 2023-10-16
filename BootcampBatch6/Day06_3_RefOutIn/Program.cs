class Program
{
	static void Main()
	{
		int x = 2;
		MultiplyByTwoRef IniReference = new MultiplyByTwoRef(ref x);
		Console.WriteLine(x);
		
		int x2;
		MultiplyByTwoOut IniOut = new MultiplyByTwoOut(out x2);
		Console.WriteLine(x2);
		
		int x3 = 2;
		MultiplyByTwoIn IniIn = new MultiplyByTwoIn(in x3);
		Console.WriteLine(x3);
	}
}

//Ref
class MultiplyByTwoRef
{
	public MultiplyByTwoRef(ref int x)
	{
		x = x * 2;
	}
}

class MultiplyByTwoOut
{
	public MultiplyByTwoOut(out int x)
	{
		x = 5;
		x = x * 2;
	}
}

class MultiplyByTwoIn
{
	public MultiplyByTwoIn(in int x)
	{
		//READ ONLY
		int y = x * 2;
	}
}