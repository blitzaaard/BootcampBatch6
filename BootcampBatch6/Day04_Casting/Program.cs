class Program
{
	static void Main()
	{
		Child c = new();
		Parent p = c;
		Child result = (Child)p;
		Console.Write(result.x); //BISA KARENA "P" DIBERIKAN CASTING "Child"
		
		// Parent p1 = new Child();
		Child c1 = (Child) new Parent();
		Console.Write(c1.x); //TIDAK BISA KARENA MESKIPUN "P" DIBERIKAN CASTING "Child", Dari awal c1 tidak punya
	}
}

class Parent{}
class Child : Parent
{
	public int x = 3;
}