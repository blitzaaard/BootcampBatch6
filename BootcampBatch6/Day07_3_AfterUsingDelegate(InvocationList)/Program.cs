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
		if(!_del.GetInvocationList().Contains(add))
        {
        	_del += add;
        }
	}
	public void Endgame()
	{
		_del?.Invoke();
	}
}