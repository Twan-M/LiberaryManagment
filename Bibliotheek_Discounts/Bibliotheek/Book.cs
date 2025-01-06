using System.Reflection;

namespace Bibliotheek;

public class Book : IDiscountable
{
    private static int _idCounter = 1; // Statische teller voor unieke IDs
    public int Id { get; private set; } // ID van het boek
    public string Title { get; set; }
    public string Author { get; set; }
    public decimal Price { get; set; }

    // De Functie ApplyDiscount kunnen toepassen op de Boeken.
    public void ApplyDiscount(decimal percentage)
    {
        Price -= Price * (percentage / 100);
    }

    //Constructor aanmaken.
    public Book(string title, string author, decimal price)//
    {
        Id = _idCounter++;
        Title = title;
        Author = author;
        Price = price;
    }

    //Zorgen dat wanneer de foreach over de boeken in de lijst heengaat deze de juiste details teruggeeft,
    // in plaats van alleen maar bijv. Bibliotheek.book
    public override string ToString()
    {
        return  $"ID: {Id}, Titel: {Title}, Auteur: {Author}, Prijs: EURO {Price}";
    }

}

public class FictionBook : Book
{
    public string Genre { get; set; }

    public FictionBook(string title, string author, decimal price, string genre) : base(title, author, price)
    {
        Genre = genre;
    }
    
    public override string ToString()
    {
        return  $"ID: {Id}, Titel: {Title}, Auteur: {Author}, Prijs: EURO {Price}";
    }
}

public class EducationalBook : Book
{
    public string Subject { get; set; }

    public EducationalBook(string title, string author, decimal price, string subject) : base(title, author, price)
    {
        Subject = subject;
    }
    
    public override string ToString()
    {
        return  $"ID: {Id}, Titel: {Title}, Auteur: {Author}, Prijs: EURO {Price}";
    }
}