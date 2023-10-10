using Day02;
using Transportation;

class Program
{
	static void Main()
	{
		// Car toyota = new Car(2, 2, "Black");
		// string state = toyota.EngineRun(true);
		// Console.WriteLine(state);
		// toyota.Move("forward");
		// Console.WriteLine(toyota.door);
		// Console.WriteLine(toyota.wheel);
		// Console.WriteLine(toyota.colour);
		
		Engine diesel = new Engine("diesel", "toyota");
		Tire hancock = new Tire("hancock", "hancock");
		Lamp osram = new Lamp("osram","osram");
		
		Car cars = new Car(diesel, osram, hancock);
	}
}