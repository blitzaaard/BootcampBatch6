class Program
{
	static void Main()
	{
		Math mat = new Math(3.3f);
		Console.WriteLine(mat.pi1);
		var asd = Math.pi2 * 2; //static
		Console.WriteLine(asd);
	}
}

public class Math
{
	public readonly float pi1;
	public const float pi2 = 3.1f;
	
	public Math(float pi1)
	{
		Console.WriteLine("Hello");
		this.pi1 = pi1;
		
		
	}
}