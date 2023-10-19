class Program
{
	static void Main()
	{
		
	}
}

public delegate void MyDelegate();

public class GameController
{
	private MyDelegate _del;
	public void AddSubscriber(MyDelegate add)
	{
		_del = add;
	}
	public void Endgame()
	{
		_del?.Invoke();
	}
}