﻿class Program
{
	static void Main()
	{
		Publisher pub = new Publisher("Jonny");
		Subscriber sub = new Subscriber();
		pub.eventHandler += sub.Notification;
		pub.SendNotification();
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
		});
	}
	public override string ToString()
	{
		return _name;
	}
}

class Subscriber
{
	public void Notification(object sender, EventData e)
	{
		Console.WriteLine($"Called by {e.name} {e.price}");
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