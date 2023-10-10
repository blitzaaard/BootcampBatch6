namespace LivingBeing;

public class Animal
{
	public string name = "";
	public int age;
	public Animal(string name)
	{
		this.name = name;
		Console.WriteLine(name);
	}
	public void Eat()
	{
		Console.WriteLine("eat");
	}
}
