class Program
{
	static void Main()
	{
		Car mobil = new(new WaterEngine());
		mobil.Move();
	}
}

class Car
{
	public IEngine engine;
	public Car (IEngine engine)
	{
		this.engine = engine;
	}
	public void Move()
	{
		engine.Run();
	}
}

public interface IEngine
{
	void Run();
}

class DieselEngine : IEngine
{
	public void Run()
	{
		Console.WriteLine("Diesel Engine Run");
	}
}

class WaterEngine : IEngine
{
	public void Run()
	{
		Console.WriteLine("Water Engine Run");
	}
}