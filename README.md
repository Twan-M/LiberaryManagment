Aggregatie: Een huis en een persoon met een kamer
Bij aggregatie is er een zwakke relatie. Een persoon kan een kamer hebben, maar die kamer kan ook bestaan zonder de persoon.

Codevoorbeeld - Aggregatie
```
using System;

class Room
{
    public string Name { get; set; }
    public Room(string name)
    {
        Name = name;
    }
}

class Person
{
    public string Name { get; set; }
    public Room Room { get; set; } // Aggregatie: Een persoon heeft een kamer

    public Person(string name, Room room)
    {
        Name = name;
        Room = room;
    }

    public void ShowRoom()
    {
        Console.WriteLine($"{Name} is in the {Room.Name}.");
    }
}

class Program
{
    static void Main()
    {
        Room room = new Room("Living Room");
        Person person = new Person("Alice", room);

        person.ShowRoom();

        // De kamer blijft bestaan, zelfs als de persoon wordt verwijderd
        person = null;

        Console.WriteLine($"The room '{room.Name}' still exists.");
    }
}
```
Compositie: Een huis en kamers
Bij compositie is er een sterke relatie. Een huis bestaat uit kamers. Als het huis wordt verwijderd, bestaan de kamers niet meer.

Codevoorbeeld - Compositie
```
using System;
using System.Collections.Generic;

class Room
{
    public string Name { get; set; }
    public Room(string name)
    {
        Name = name;
    }
}

class House
{
    public string Address { get; set; }
    private List<Room> Rooms { get; set; } // Compositie: Een huis "bevat" kamers

    public House(string address)
    {
        Address = address;
        Rooms = new List<Room>(); // Kamers worden binnen het huis gemaakt
    }

    public void AddRoom(string roomName)
    {
        Rooms.Add(new Room(roomName));
    }

    public void ShowRooms()
    {
        Console.WriteLine($"House at {Address} has the following rooms:");
        foreach (var room in Rooms)
        {
            Console.WriteLine($"- {room.Name}");
        }
    }
}

class Program
{
    static void Main()
    {
        House house = new House("123 Main Street");
        house.AddRoom("Living Room");
        house.AddRoom("Bedroom");

        house.ShowRooms();

        // Als het huis wordt verwijderd, worden de kamers ook verwijderd
        house = null;

        // De kamers zijn niet meer toegankelijk
        Console.WriteLine("The house and its rooms no longer exist.");
    }
}
```
Samenvatting in Context
Scenario	Aggregatie	Compositie
Relatie	Persoon heeft een kamer	Huis bestaat uit kamers
Object onafhankelijkheid	Kamer blijft bestaan zonder persoon	Kamer kan niet bestaan zonder huis
Voorbeeld in code	Person → Room	House → Room
