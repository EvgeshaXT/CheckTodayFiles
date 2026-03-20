# CheckTodayFiles
It's just console app that finds files created today

I created this repository purely for fun. I know that my work is worthless, as it is too easy to create lol. But let it be here as my own work.

This program is written in C#, net10.0.
U can see the code in Program.cs or I can duplicate here:
```c#
string videosPath = @"YOUR_PATH";

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
```

And yeah, single Exception is written in Russian xd
