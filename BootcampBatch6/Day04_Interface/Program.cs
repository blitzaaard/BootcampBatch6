class Program
{
	static void Main()
	{
		Saya me = new();
		me.Kuliah();
		me.Kerja();
		me.Bermain();
		me.KerjaPR();
		me.UangJajan(100);
		
		Saya2 me2 = new();
		me2.Kuliah();
		me2.Kerja();
		me2.Bermain();
		me2.KerjaPR();
		me2.UangJajan(1000);
		me2.AntarBelanja();
	}
}

public abstract class PermintaanIbu
{
	public abstract void AntarBelanja(); 
} 
public interface IPermintaanOrtu
{
	void Kuliah();
	void Kerja();
}

public interface IPermintaanAdik
{
	void Bermain();
	void KerjaPR();
	int UangJajan(int value);
}

class Saya : IPermintaanOrtu, IPermintaanAdik
{
	public void Kuliah()
	{
		Console.WriteLine("Kuliah");
	}
	public void Kerja()
	{
		Console.WriteLine("kerja");
	}
	public void KerjaPR()
	{
		Console.WriteLine("Kerja PR");
	}
	public void Bermain()
	{
		Console.WriteLine("Bermain");
	}
	public int UangJajan(int value)
	{
		return value;
	} 
}

class Saya2 : PermintaanIbu, IPermintaanOrtu, IPermintaanAdik
{
	public void Kuliah()
	{
		Console.WriteLine("Kuliah");
	}
	public void Kerja()
	{
		Console.WriteLine("Belum Kerja");
	}
	public void KerjaPR()
	{
		Console.WriteLine("Tidak bantu kerja PR");
	}
	public void Bermain()
	{
		Console.WriteLine("Tidak Bermain");
	}
	public int UangJajan(int value)
	{
		return value;
	} 
	public override void AntarBelanja()
	{
		Console.WriteLine("Antar Belanja");
	}
}