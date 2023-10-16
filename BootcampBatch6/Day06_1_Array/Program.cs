class Program
{
	static void Main()
	{
		int[] myArr = new int[100];
		char[] myChar = new char[10];
		string[] myString = {"red", "green", "blue"};
		
		myArr [0] = 200;
		Console.WriteLine(myArr[0]);
		Console.WriteLine(myArr.Length);
	}
}