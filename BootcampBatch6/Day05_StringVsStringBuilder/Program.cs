using System.Diagnostics;
using System.Text;

class Program
{
	static void Main()
	{
		Stopwatch stopwatch = new Stopwatch();
		string x = string.Empty;
		stopwatch.Start();
		for(int i = 0; i<10000 ; i++)
		{
			x += "Hello";
			x += "World";
			x += "!";
		}
		stopwatch.Stop();
		Console.WriteLine($"String: {stopwatch.ElapsedMilliseconds} ms"); // 496 ms
		
		StringBuilder y = new StringBuilder();
		stopwatch.Restart();
		for(int i = 0; i<10000 ; i++)
		{
			y.Append("Hello");
			y.Append("World");
			y.Append("!");
		}
		stopwatch.Stop();
		Console.WriteLine($"String Builder: {stopwatch.ElapsedMilliseconds} ms"); // 0 ms
	}
}