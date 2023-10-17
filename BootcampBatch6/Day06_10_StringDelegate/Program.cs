class Program
{
	public delegate string MyDelegate();
	static void Main()
	{
		MyDelegate del = Red;
		del += Blue;
		string res = del(); //INVOKE (HANYA YANG TERAKHIR MASUK)
		Console.WriteLine(res);
	}
	static string Red()
	{
		return "Red";
	}
	static string Blue()
	{
		return "Blue";
	}
}