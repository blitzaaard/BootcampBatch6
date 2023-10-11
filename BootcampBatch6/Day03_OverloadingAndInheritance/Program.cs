class Program
{
	static void Main()
	{
		Parent ayah = new("papa");
		int hasil = ayah.count(2, 3);
		Console.WriteLine(hasil);
		int hasil2 = ayah.count(2, 3, 4);
		Console.WriteLine(hasil2);
		
		Child child = new("anak");
		Child child2 = new();
		
		
	}
}

class Parent
{
	protected string name;
	
	public Parent()
	{
		
	}
	public Parent(string name)
	{
		this.name = name;
		Console.WriteLine(name);	
	}
	
	public int count(int a, int b)
	{
		return a+b;
	}
	
	public int count(int a, int b, int c)
	{
		return a+b+c;
	}
}

class Child : Parent
{
	public Child(string name) : base (name)
	{
		// Console.WriteLine(name);
	}
	public Child() : base ("default name")
	{
		// this.name = name;
		// Console.WriteLine(name);
	}
}