class Program
{
	static void Main()
	{
		ITransport[] arr = new ITransport[100];
		arr[0] = new Car();
		arr[1] = new Truck();
		arr[2] = new Motorcycle();
		// myList.Add(new Mouse());
	}
}

public interface ITransport{}
class Car : ITransport{}
class Truck : ITransport{}
class Motorcycle : ITransport{}
class Mouse{}
