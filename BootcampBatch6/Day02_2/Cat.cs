namespace LivingBeing;

public class Cat : Animal
{
	public Cat(string name) : base(name)
	{
		Console.WriteLine("Cat Created");
	}
	public void Jump()
	{
		Console.WriteLine("Jump");
	}
	public void Meow()
	{
		Console.WriteLine("Meow");
	}
}
