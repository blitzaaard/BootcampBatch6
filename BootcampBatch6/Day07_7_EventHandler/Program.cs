﻿class Program
{
	static void Main(){
		Youtuber pub = new Youtuber("Jonny");
		Subscriber sub = new();
		pub.eventHandler += sub.Notification;
		pub.SendNotification();
	}
}

class Youtuber
{
	private string _name;
	public EventHandler eventHandler;
	public Youtuber(string name)
	{
		_name = name;
	}
	public void SendNotification()
	{
		eventHandler?.Invoke(this, EventArgs.Empty);
	}
	public override string ToString()
	{
		return _name;
	}
}

class Publisher
{
	private string _name;
	public EventHandler eventHandler;
	public Publisher(string name)
	{
		_name = name;
	}
	public void SendNotification()
	{
		eventHandler?.Invoke(this, EventArgs.Empty);
	}
	public override string ToString()
	{
		return _name;
	}
}

class Subscriber
{
	public void Notification(object sender, EventArgs e)
	{
		Console.WriteLine($"Called by {sender}");
	}
}