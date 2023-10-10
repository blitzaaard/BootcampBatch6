using System;
using LivingBeing;

class Program
{
	static void Main()
	{
		Cat item = new Cat("kucing hitam");
		item.name = "item";
		Console.WriteLine(item.name);
	}
}