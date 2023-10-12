class Program
{
	static void Main()
	{
		Parent c = new Child();
		c.Kuliah();
		c.Kerja();
	}
	
}

public abstract class Parent
{
	public abstract void Kuliah();
	public virtual void Kerja()
	{
		Console.WriteLine("Kerja");
	}
}

public class Child : Parent
{
	public override void Kuliah()
	{
		Console.WriteLine("Kuliah di UGM");
	}
	
	public override void Kerja()
	{
		Console.WriteLine("Kerja di Kantor");
	}
	
}