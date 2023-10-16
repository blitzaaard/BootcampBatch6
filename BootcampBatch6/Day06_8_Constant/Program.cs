class Program
{
	static void Main()
	{
		MyMath math = new MyMath();
		//math.phi.Dump(); //CANNOT CALL STATIC VARIABLE FROM INSTANCE

		Console.WriteLine(MyMath.phi);
	}
	class MyMath
	{
		public const float phi = 3.14f; //CONST = STATIC
	}
}