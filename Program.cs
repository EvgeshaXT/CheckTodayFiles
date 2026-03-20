string videosPath = @"C:\\Users\EvgeshaXT\Videos\";

ProcessFolder(videosPath);

void ProcessFolder(string path)
{
    try
    {
        string[] files = Directory.GetFiles(path);
        foreach (string file in files)
        {
            CheckFile(file);
        }

        string[] folders = Directory.GetDirectories(path);
        foreach (string folder in folders)
        {
            ProcessFolder(folder);
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Ошибка какая-то: {ex.Message}");
    }
}

void CheckFile(string filePath)
{
    FileInfo fileInfo = new(filePath);
    
    if (fileInfo.CreationTime.Date == DateTime.Today)
    {
        Console.WriteLine($"{fileInfo.Name} [{fileInfo.CreationTime}]");
    }
}