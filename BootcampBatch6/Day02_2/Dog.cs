namespace LivingBeing;

public class Dog : Animal
{
	public Dog(string name) : base(name)
	{
		Console.WriteLine("Dog Created");
	}
	public void Run()
	{
		Console.WriteLine("Run");
	}
	public void Bark()
	{
		Console.WriteLine("Bark");
	}
}
