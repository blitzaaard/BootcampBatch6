class Program
{
	public delegate void MyDelegate();
	static void Main()
	{
		MyDelegate del = Red;
		del += Blue;
		del(); //INVOKE (BISA BEBERAPA)
	}
	static void Red()
	{
		Console.WriteLine("Red");
	}
	static void Blue()
	{
		Console.WriteLine("Blue");
	}
}