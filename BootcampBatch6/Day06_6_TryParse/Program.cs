class Program
{
	static void Main()
	{
		string myString = "351a";
		bool statusParsing = int.TryParse(myString, out int result);
		Console.WriteLine(result);
		Console.WriteLine(statusParsing);
	}
}