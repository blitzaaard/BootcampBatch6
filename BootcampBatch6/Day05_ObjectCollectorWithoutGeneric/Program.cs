class Program
{
	static void Main()
	{
		//ONLY INT, BUT THERE ARE STRING AND DOUBLE LEFT
		IntCollection obj = new();
		obj.Add(1);

		int result = (int)obj.myCollection[0];
		Console.WriteLine(result);
	}
}

class IntCollection
{
	public int[] myCollection = new int[100];
	public int count = 0;

	public void Add(int input)
	{
		myCollection[count] = input;
		count++;
	}
}
class StringCollection
{
	public string[] myCollection = new string[100];
	public int count = 0;

	public void Add(string input)
	{
		myCollection[count] = input;
		count++;
	}
}
class DoubleCollection
{
	public double[] myCollection = new double[100];
	public int count = 0;

	public void Add(double input)
	{
		myCollection[count] = input;
		count++;
	}
}