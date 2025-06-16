namespace EspinosaApp;

public partial class NotePage
{
    public partial class NotePage : ContentPage
	{
		string _fileName = Path.Combine(FileSystem.AppDataDirectory, "notes.txt");
	}
}