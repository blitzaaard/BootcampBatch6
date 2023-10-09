using Animal;
class Program
{
	static void Main (string[] args)
	{
		Cat oyen = new Cat();
		oyen.colour = "orange";
		oyen.leg = 5;
		oyen.isAnyTail = true;
		Console.WriteLine(oyen.colour);
		Console.WriteLine(oyen.leg);
		oyen.jump();
		oyen.run();
	}
}