using System.Collections.ObjectModel;

class Program
{
	static void Main()
	{
		GenericCollector<int> gen = new();
		gen.Add(1);
		gen.Add(122);
		
		GenericCollector<float> gen2 = new();
		gen2.Add(1.22f);
		gen2.Add(122.33f);
		//ONLY ADD ON TO AN ARRAY WHEN THE TYPE DATA IS SAME
	}
}

class GenericCollector<T>
{
	public T[] myCollection = new T[100];
	public int count = 0;
	public void Add(T input)
	{
		myCollection[count] = input;
		count++;
	}
}