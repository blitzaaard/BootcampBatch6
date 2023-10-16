using System.Collections.ObjectModel;

class Program
{
	static void Main()
	{
		GenericCollector<int, string> gen = new();
		gen.Add(1, "red");
		gen.Add(122, "blue");
		//ONLY ADD ON TO AN ARRAY WHEN THE TYPE DATA IS SAME
	}
}

class GenericCollector<T, T2>
{
	public T[] myCollection = new T[100];
	public T2[] myCollection2 = new T2[100];
	public int count = 0;
	public void Add(T input, T2 input2)
	{
		myCollection[count] = input;
		myCollection2[count] = input2;
		count++;
	}
}