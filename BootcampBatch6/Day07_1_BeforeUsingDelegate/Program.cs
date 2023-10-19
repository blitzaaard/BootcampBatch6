class UI
{
	public void UpdateUI(string ui){}
}
class Database
{
	public void UpdateDatabase(string db){}
}
class File
{
	public void UpdateFile(string file){}
}

class GameController
{
	private UI _ui;
	private Database _db;
	private File _file;
	
	public GameController(UI ui, Database db, File file)
	{
		_ui = ui;
		_db = db;
		_file = file;
	}
	public void EndGame()
	{
		_ui.UpdateUI("DATA");
		_db.UpdateDatabase("DATA");
		_file.UpdateFile("DATA");
	}
}

class Program
{
	static void Main()
	{
		
	}
}