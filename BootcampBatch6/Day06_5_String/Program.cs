class Program
{
	static void Main()
	{
		string myString =  "Hello";
		stringAppender str = new stringAppender(ref myString);
		Console.WriteLine(str.input);
	}
}

class stringAppender
{
	public string input = null;
	public stringAppender(ref string input)
	{
		this.input = input + "!";
	}
}