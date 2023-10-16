class Program
{
	static void Main()
	{
		Car car = new Car(2000); //Reference Type
		MultiplyByTwoCar mul =  new MultiplyByTwoCar(car);
		Console.WriteLine(car.price); // 4000
	}
}

class MultiplyByTwoCar
{
	public MultiplyByTwoCar(Car input){
		input.price = input.price * 2;
	}
}

class Car
{
	public int price;
	public Car(int value)
	{
		price = value;
	}
}
