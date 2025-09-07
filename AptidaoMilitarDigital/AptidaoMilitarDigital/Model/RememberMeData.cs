using System.IO;
using System.Text.Json;

public class RememberMeData
{
    public string Username { get; set; }
    public string Password { get; set; } 
    public bool RememberMe { get; set; }
}

public class RememberMeManager
{
    private static readonly string FilePath = Path.Combine(
    Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
    "AptidaoMilitarDigital",
    "rememberMe.json"
);

    public void Save(RememberMeData data)
    {
        string pasta = Path.GetDirectoryName(FilePath);
        if (!Directory.Exists(pasta))
            Directory.CreateDirectory(pasta);

        string json = JsonSerializer.Serialize(data);
        File.WriteAllText(FilePath, json);
    }

    public RememberMeData Load()
    {
        if (!File.Exists(FilePath)) return null;

        string json = File.ReadAllText(FilePath);
        return JsonSerializer.Deserialize<RememberMeData>(json);
    }

    public void Clear()
    {
        if (File.Exists(FilePath))
            File.Delete(FilePath);
    }
}

