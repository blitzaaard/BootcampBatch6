class Program
{
	static void Main()
	{
		int a = 2;
		int b = 3;
		Calculator myCalc = new();
		int result = myCalc.NonStaticAdder(a, b);
		Console.WriteLine(result);
		Console.WriteLine(Calculator.Add(a,b));
		
		Car carA = new Car();
		Car carB = new Car();
		carB.SetPrice(10);
		carA.SetPrice(11);
		
		Console.WriteLine(carA.GetPrice());
		Console.WriteLine(carB.GetPrice());
		Console.WriteLine(Car.StaticPrice);
	}
}
class Calculator
{
	public static int Add(int left, int right)
	{
		return left + right;
	}
	public int NonStaticAdder(int left, int right)
	{
		return left + right;
	}
}

class Car
{
	public static int StaticPrice;
	
	public void SetPrice(int price)
	{
		StaticPrice = price;
	}
	
	public int GetPrice()
	{
		return StaticPrice;
	}
}