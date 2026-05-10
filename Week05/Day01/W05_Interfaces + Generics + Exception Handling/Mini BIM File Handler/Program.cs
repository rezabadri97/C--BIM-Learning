using System;
using System.Collections.Generic;

interface IPrintable
{
    void Print();
}

interface ISavable
{
    void Save();
}

class RoomScheduleFile : IPrintable, ISavable
{
    public string FileName { get; set; }

    public RoomScheduleFile(string fileName)
    {
        FileName = fileName;
    }

    public void Print()
    {
        Console.WriteLine("Printing Room Schedule File: " + FileName);
    }

    public void Save()
    {
        Console.WriteLine("Saving Room Schedule File: " + FileName);
    }
}

class DoorScheduleFile : IPrintable, ISavable
{
    public string FileName { get; set; }

    public DoorScheduleFile(string fileName)
    {
        FileName = fileName;
    }

    public void Print()
    {
        Console.WriteLine("Printing Door Schedule File: " + FileName);
    }

    public void Save()
    {
        Console.WriteLine("Saving Door Schedule File: " + FileName);
    }
}

class ProjectSummaryFile : IPrintable, ISavable
{
    public string FileName { get; set; }

    public ProjectSummaryFile(string fileName)
    {
        FileName = fileName;
    }

    public void Print()
    {
        Console.WriteLine("Printing Project Summary File: " + FileName);
    }

    public void Save()
    {
        Console.WriteLine("Saving Project Summary File: " + FileName);
    }
}

class FileManager
{
    private List<IPrintable> _printableFiles = new List<IPrintable>();
    private List<ISavable> _savableFiles = new List<ISavable>();

    public void AddFile(IPrintable printableFile, ISavable savableFile)
    {
        _printableFiles.Add(printableFile);
        _savableFiles.Add(savableFile);
    }

    public void PrintAll()
    {
        Console.WriteLine("=== Printing All Files ===");
        foreach (IPrintable file in _printableFiles)
        {
            file.Print();
        }
    }

    public void SaveAll()
    {
        Console.WriteLine("=== Saving All Files ===");
        foreach (ISavable file in _savableFiles)
        {
            file.Save();
        }
    }
}

class Program
{
    static void Main()
    {
        FileManager manager = new FileManager();

        RoomScheduleFile roomFile = new RoomScheduleFile("room_schedule.txt");
        DoorScheduleFile doorFile = new DoorScheduleFile("door_schedule.txt");
        ProjectSummaryFile summaryFile = new ProjectSummaryFile("project_summary.txt");

        manager.AddFile(roomFile, roomFile);
        manager.AddFile(doorFile, doorFile);
        manager.AddFile(summaryFile, summaryFile);

        manager.PrintAll();
        Console.WriteLine();
        manager.SaveAll();
    }
}
