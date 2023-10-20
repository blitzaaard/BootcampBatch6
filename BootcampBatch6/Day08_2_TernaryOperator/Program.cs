class Program
{
	static void Main()
	{
		string result = ReturnString(5,6);
		Console.WriteLine(result);
	}
	
	static string ReturnString(int a, int b)
	{
		return a>b ? "true" : "false";
	}
}