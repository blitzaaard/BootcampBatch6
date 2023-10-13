class Program
{
	static void Main()
	{
		Car car1 = new Car(3);
		Car car2 = car1;
		car2.x = 5;
		Console.WriteLine(car1.x);
		Console.WriteLine(car2.x);
	}
}

class Car
{
	public int x;
	public Car(int x)
	{
		this.x = x;
	}
}