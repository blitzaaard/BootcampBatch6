class Program
{
	static void Main()
	{
		List<ITransport> myList = new List<ITransport>();
		myList.Add(new Car());
		myList.Add(new Truck());
		myList.Add(new Motorcycle());
		// myList.Add(new Mouse());
	}
}

public interface ITransport{}
class Car : ITransport{}
class Truck : ITransport{}
class Motorcycle : ITransport{}
class Mouse{}
