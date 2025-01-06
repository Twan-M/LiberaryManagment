using Bibliotheek;

namespace BibliotheekS
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Lijst aanmaken met alle boeken.
            List<Book> books = new List<Book>
            {
                new Book("Joehoe", "Twan", 19.99m),
                new FictionBook("Scream", "Twan", 9.95m, "Horror"),
                new EducationalBook("Bosatlas", "Twan", 69.99m, "Aadrijkskunde")
            };
            
            Console.WriteLine("Boekenlijst:");
            //Door de lijst Boeken heengaan, en alle boeken tonen in de console.
            foreach (Book book in books)
            {
                Console.WriteLine(book);
            }
            
            Console.WriteLine("\nVoer het ID in van het boek dat je wilt kopen:");
            // Console lezen en antwoord parsen naar Int. Readline zelf wordt ALTIJD String
            //Opslaan aals selectedId
            if (int.TryParse(Console.ReadLine(), out int selectedId))
            {
                // Zoek het geselecteerde boek in de lijst met boeken. En toewijzen aan de var selectedBook
                Book selectedBook = books.Find(book => book.Id == selectedId);
                if (selectedBook != null)
                {
                    // Boek tergugeven met de huidige prijs.
                    Console.WriteLine($"\nJe hebt '{selectedBook.Title}' gekozen. De prijs is: EURO {selectedBook.Price}");
                    
                    Console.WriteLine("Voer het kortingspercentage in (bijvoorbeeld 10 voor 10%):");
                    if (decimal.TryParse(Console.ReadLine(), out decimal discountPercantage))
                    {
                        selectedBook.ApplyDiscount(discountPercantage);
                        Console.WriteLine($"\nDe prijs na {discountPercantage}% korting is: EURO {selectedBook.Price:F2}");

                    }
                }
            }
        }
    }
}