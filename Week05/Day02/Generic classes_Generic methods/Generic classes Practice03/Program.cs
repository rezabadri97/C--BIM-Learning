using System;
using System.Xml.Linq;
class Room
{
    public string name;
    public string Name
    {
        get
        {
            return name;
        }
        set
        {
            name = value;
        }
    }
    public Room(string name)
    {
        Name = name;
    }
}
class Wall
{
    public double length ;
    public double Length
    {
        get
        {
            return length;
        }
        set
        {
            length=value ;
        }
    }
    public Wall(double length)
    {
        Length=length;
    }
}
class Door
{
    public int count;
    public int Count
    {
        get
        {
            return count;
        }
        set
        {
            Count = value;
        }
    }
    public Door(int count)
    {
        Count=count;
    }
}
class Repository<T>
{
    private List<T> _items=new List<T>();

    public void Add(T item)
    {
        _items.Add(item);
    }
    public List<T> GetAll()
    {
        return _items;
    }
}   
class Program
{
    static void Main(string[] args)
    {
        Repository<Room> elements=new Repository<Room>();
        elements.Add(new Room("Room 101"));
        elements.Add(new Room("Kitchen"));
        elements.Add(new Room("Office"));
        
        foreach(Room room in elements.GetAll())
        {
            Console.WriteLine(room.Name);
        }
    }
}