class Program
{
	static void Main()
	{
		Engine general = new Engine();
		Engine general2 = new DieselEngine();
		
		DieselEngine diesel = new();
		ElectricEngine electric = new();
		
		Car car = new Car(electric);
		car.EngineStart();
	}
}

class Car
{
	private Engine _engine;
	public Car(Engine e)
	{
		_engine = e;
	}
	public void EngineStart()
	{
		_engine.Run();
		// _engine.WarmUp; //ERROR karena Class Engine tidak punya WarmUp
	}
}

class Engine
{
	public virtual void Run()
	{
		Console.WriteLine("Engine Run");
	}
}

class DieselEngine : Engine
{
	public override void Run()
	{
		Console.WriteLine("Diesel Engine Run");
	}
	public void WarmUp()
	{
		Console.WriteLine("Diesel Engine Warm Up");
	}
}

class ElectricEngine : Engine
{
	public override void Run()
	{
		Console.WriteLine("Electric Engine Run");
	}
}