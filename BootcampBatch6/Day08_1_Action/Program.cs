//Action?
class Program
{
	static void Main()
	{
		Action<string> act = null;
		act?.Invoke("hello");
	}
	public void Printer(string message)
	{
		Console.WriteLine(message);
	}
	
	public void Update(string message)
	{
		Console.WriteLine(message);
	}
}