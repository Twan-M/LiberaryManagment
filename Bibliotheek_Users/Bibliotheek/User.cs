namespace Bibliotheek;

public class User
{
    private static int _idCounter = 1; // Statische teller voor unieke IDs
    public int Id { get; set; }
    public string Name { get; set; }

    public User(string name)
    {
        Id = _idCounter++;
        Name = name;
    }

    public override string ToString()
    {
        return $"Gebruiker ID: {Id}, Naam: {Name}";
    }
}