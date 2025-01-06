using System.Collections.Concurrent;
using Bibliotheek;

namespace BibliotheekS
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Lijst met boeken maken
            List<Book> books = new List<Book>
            {
                new Book("Joehoe", "Twan", 19.99m),
                new FictionBook("Scream", "Twan", 9.95m, "Horror"),
                new EducationalBook("Bosatlas", "Twan", 69.99m, "Aardrijkskunde")
            };
            
            //Gebruiker Aanmaken
            User user = new User("Piertje");
            
            //Order aanmaken voor Gebruiker
            Order order = new Order(user);

            while (true)
            {
                Console.WriteLine("Beschikbare boeken:");
                //Voor elk boek in de MAIN lijst boeken, het boek naar de console printen.
                foreach (Book book in books)
                {
                    Console.WriteLine(book);
                }
                
                Console.WriteLine("Voer het boek ID in dat je wilt toevoegen:");
                //Eerste kan wel gewoon op deze manier, omdat Stop een string is. Wanneer Stop is getypt, stop de loop.
                string input = Console.ReadLine();

                if (input.ToLower() == "stop")
                {
                    break;
                }
                //Als er wel een INT is, deze opslaan als selectedId
                if (int.TryParse(input, out int selectedId))
                {
                    // Book ID matchen met de bestaande boek IDs in de lijst Books.
                    Book selectedBook = books.Find(book => book.Id == selectedId);
                    if (selectedBook != null)
                    {
                        //Boek toevoegen aan de lijst van de CLASS, zodat de Order een boek toegevoegd krijgt,
                        order.AddBook(selectedBook);
                        Console.WriteLine($"'{selectedBook.Title}' is toegevoegd aan je bestelling.");
                    }
                }
            }
            Console.WriteLine("Je bestelling:");
            order.PrintOrderDetails();
        }
    }
}