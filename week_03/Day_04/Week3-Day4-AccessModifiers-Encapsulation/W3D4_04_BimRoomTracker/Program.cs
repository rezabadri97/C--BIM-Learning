using System;

internal class BimRoomTracker
{
    public string RoomName { get; set; }
    private int revisionCount;

    public BimRoomTracker(string roomName)
    {
        RoomName = roomName;
        revisionCount = 0;
    }

    public void RegisterRevision()
    {
        revisionCount++;
    }

    public int GetRevisionCount()
    {
        return revisionCount;
    }
}

class Program
{
    static void Main()
    {
        BimRoomTracker tracker = new BimRoomTracker("Office 201");

        tracker.RegisterRevision();
        tracker.RegisterRevision();
        tracker.RegisterRevision();

        Console.WriteLine("Room: " + tracker.RoomName);
        Console.WriteLine("Revisions: " + tracker.GetRevisionCount());
    }
}
