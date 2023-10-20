class Program{
	static void Main()
	{
		Car car = new Car();
		car.x.Dump();
		//car.engine.Test();
		car.y.Length.Dump();
	}
}

class Car {
	public Engine engine;
	public string? y;
	public int x;
}
class Engine
{
	public void Test() {
		Console.WriteLine("test");
	}
}