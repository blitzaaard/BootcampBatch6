class Program
{
	static void Main()
	{
		ObjectCollection obj = new();
		obj.Add(1);
		obj.Add(2);
		obj.Add(true);
		Console.WriteLine();
	}
}

class ObjectCollection
{
	public object[] myCollection = new object[100];
	public int count = 0;
	public void Add(object input)
	{
		myCollection[count] = input;
		count++;
	}
}