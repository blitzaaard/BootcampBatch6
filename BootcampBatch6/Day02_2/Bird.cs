namespace LivingBeing;

public class Bird : Animal
{
	public Bird(string name) : base(name)
	{
		Console.WriteLine("Bird Created");
	}
	public void Fly()
	{
		Console.WriteLine("Fly");
	}
	public void Chip()
	{
		Console.WriteLine("Chip");
	}
}
