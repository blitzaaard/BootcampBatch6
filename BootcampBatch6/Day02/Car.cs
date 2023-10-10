using Day02;

namespace Transportation
{
	class Car
	{
		public int door;
		public int wheel;
		public string colour = "";
		
		// public Car(int door, int wheel, string colour)
		// {
		// 	this.door = door;
		// 	this.wheel = wheel;
		// 	this.colour = colour;
		// }
		
		public Engine engine;
		public Lamp lamp;
		public Tire tire;
		public Car(Engine engine, Lamp lamp, Tire tire)
		{
			Console.WriteLine("Car");
			this.engine = engine;
			this.lamp = lamp;
			this.tire = tire;
		}
		public void Move(string direction)
		{
			Console.WriteLine("\nMove to " + direction + " now");
			Console.WriteLine($"Move to {direction} now");
			Console.WriteLine($"Move to {direction} now");
		}
		public string EngineRun(bool state)
		{
			if(state)
			{
				return "Engine Run";
			}
			else
			{
				return "Engine Stop";
			}
		} 
	}
}