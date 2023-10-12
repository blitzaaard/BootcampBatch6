class Program
{
	static void Main()
	{
		int a = 1;
		int b = 2;
		int c = 3;
		Console.WriteLine((a+b==c)); //True
		
		float fa = 1.0f;
		float fb = 2.0f;
		// float fc = 3.2f;
		Console.WriteLine((fa+fb==3.0f)); //True
		
		double da = 0.1;
		double db = 0.2;
		Console.WriteLine((da+db==0.3)); //False
		
		decimal ma = 1.1M;
		decimal mb = 2.1M;
		decimal mc = 3.2M;
		Console.WriteLine((ma+mb==mc)); //True
	}
}