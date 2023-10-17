class Program
{
	public delegate int MyDelegate(int left, int right);
	static void Main()
	{
		MyDelegate del = Add;
		del += Mul;
		int res = del(2, 5); //INVOKE (HANYA YANG TERAKHIR MASUK)
		Console.WriteLine(res);
	}
	static int Add(int left, int right)
	{
		return left + right;
	}
	static int Mul(int left, int right)
	{
		return left * right;
	}
}