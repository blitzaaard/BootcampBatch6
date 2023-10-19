public delegate void MyDelegate(string uploader);
class Program
{
	static void Main()
	{
		Youtuber yt = new("Yanto");
		Subscriber sub1 = new Subscriber();
		
		yt.subscriber += sub1.Notification;
		
		yt.UploadVideo();
		yt.EventClear();
	}
}

class Youtuber
{
	public event MyDelegate subscriber;
	private string _name;
	
	public Youtuber(string name)
	{
		_name = name;
	}
	public void UploadVideo()
	{
		Console.WriteLine("Uploading Video");
		if (subscriber != null)
		{
			subscriber?.Invoke(_name);
		}
	}
	public void EventClear()
	{
		subscriber = null;
	}
}

class Subscriber
{
	public void Notification(string x)
	{
		Console.WriteLine($"Get notification from Youtuber {x}");
	}
}