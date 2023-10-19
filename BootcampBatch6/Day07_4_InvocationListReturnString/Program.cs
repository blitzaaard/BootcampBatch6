class Program
{
	public delegate string MyDelegate();
	static void Main()
	{
		MyDelegate del = Message.ThisIsMessage;
		del += Message.DotNet;
		
		List<string> result = new();
		Delegate[] delegateList = del.GetInvocationList();
		foreach(MyDelegate d in delegateList)
		{
			result.Add(d.Invoke());
		}
		Console.WriteLine(result);		
	}
}

class Message
{
	public static string ThisIsMessage()
	{
		return "Message";
	}
	public static string DotNet()
	{
		return "Dotnet";
	}
}