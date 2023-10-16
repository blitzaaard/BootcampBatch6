using System.Numerics;

class Program
{
	static void Main()
	{
		Combiner<int> comb = new();
		comb.Add(2,3);
		
		Combiner<Car> car = new();
		Car result = car.Add(new Car(2000), new Car(5000));
		Console.WriteLine(result.GetPrice());
		
		Car carA = new Car(5000);
		Car carB = new Car(25000);
		Car carTotal = carA + carB;
		Console.WriteLine(carTotal.GetPrice());
		
		Car carTotal2 = carB - carA;
		Console.WriteLine(carTotal2.GetPrice());
	}
}

class Combiner<T> where T : IAdditionOperators <T, T, T>
{
	public T Add(T a, T b)
	{
		return a+b;
	}
}

class Car : IAdditionOperators<Car, Car, Car>
{
	private int _price;
	public Car (int price)
	{
		_price = price;
	}
	public int GetPrice()
	{
		return _price;
	}
	public static Car operator + (Car left, Car right) //OPERATOR OVERLOADING (+)
	{
		return new Car(left.GetPrice() + right.GetPrice());
	}
	public static Car operator - (Car left, Car right) //OPERATOR OVERLOADING (-)
	{
		return new Car(left.GetPrice() - right.GetPrice());
	}
}