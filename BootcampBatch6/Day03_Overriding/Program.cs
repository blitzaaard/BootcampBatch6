class Program
{
	static void Main()
	{
		//Virtual Override
		Cat kucing = new();
		kucing.MakeSound(); //Meow
		Animal kucing1 = kucing; //Meow
		kucing1.MakeSound();
		
		//Virtual Inherit
		Dog anjing = new();
		anjing.MakeSound(); //MakeSound
		Animal anjing1 = anjing; //MakeSound
		anjing1.MakeSound();
		
		//Virtual Hiding
		Bird burung = new();
		burung.MakeSound(); //Chip
		Animal burung1 = burung; //MakeSound
		burung1.MakeSound();
		
		//Virtual Virtual = Virtual Hiding {Memory Not Deleted}
		Ant semut = new();
		semut.MakeSound(); //Chip
		Animal semut1 = semut; //MakeSound
		semut1.MakeSound();
	}
}

class Animal
{
	public virtual void MakeSound()
	{
		Console.WriteLine("Make Sound");
	}
}

class Cat : Animal
{
	public override void MakeSound()
	{
		Console.WriteLine("Meow");
	}
}

class Dog : Animal{}

class Bird : Animal
{
	public new void MakeSound()
	{
		Console.WriteLine("Chip");
	}
}

class Ant : Animal
{
	public virtual void MakeSound()
	{
		Console.WriteLine("Ant");
	}
}