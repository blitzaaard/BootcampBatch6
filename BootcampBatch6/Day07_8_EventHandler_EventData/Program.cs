class Program
{
	static void Main()
	{
		
	}
}

class Publisher
{
	private string _name;
	public EventHandler<EventData> eventHandler;
	public Publisher(string name)
	{
		_name = name;
	}
	public void SendNotification()
	{
		eventHandler?.Invoke(this, new EventData()
												{
													name = "Jokoyanto",
													price = 2000
												}
		)
	}
}

class EventData : EventArgs
{
	public string name;
	public int price;
	public void Printer(string message)
	{
		Console.WriteLine(message);	
	}
	
}