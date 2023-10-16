class Program
{
	static void Main()
	{
		MyCollection<string> col = new();
		col.SetValue(0,"red");
		col.SetValue(5,"blue");

		Console.WriteLine(col.GetValue(0)); 
		Console.WriteLine(col.GetValue(1)); //null
	}
}

class MyCollection<T>
{
	private T[] collection = new T[100];
	
	public T GetValue(int index)
	{
		if (index >= 0 && index < collection.Length-1)
		{
			return collection[index];
		}
		throw new IndexOutOfRangeException("Not Found Data");
	}
	public void SetValue(int index, T value)
	{
		collection[index] = value;
	}
}