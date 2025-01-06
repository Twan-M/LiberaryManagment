namespace Bibliotheek;

public class Order
{
    private static int _idCounter = 1; // Statische teller voor unieke IDs
    public int Id { get; set; }
    // Field met het type User. (Bestaande class)
    public User User { get; set; }
    //Lijst van het type Books (Bestaande class)
    public List<Book> Books { get; set; }

    public Order(User user)
    {
        Id = _idCounter++;
        User = user;
        Books = new List<Book>();
    }

    //Boek toevoegen aan de lijst in de Class. (Dus voor de order zelf)
    public void AddBook(Book book)
    {
        Books.Add(book);
    }
    
    public override string ToString()
    {
        return $"Order ID: {Id}, {User}, Aantal boeken: {Books.Count}";
    }

    // Printen naar console welke boeken er in de lijst van de huidige order zitten
    public void PrintOrderDetails()
    {
        //This omdat het om de huidige Order gaat.
        Console.WriteLine(this);
        foreach (var book in Books)
        {
            Console.WriteLine(book);
        }
    }
}