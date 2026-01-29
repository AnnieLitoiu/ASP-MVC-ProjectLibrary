using ProjectLibrary.DAL.Entities;
using ProjectLibrary.DAL.Services;

namespace ProjectLibrary.TestConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BookService service = new BookService();
            /* Test GetAll
            IEnumerable<Book> library = service.Get();

            foreach (Book b in library)
            {
                Console.WriteLine($"\"{b.Title}\" écrit par {b.Author}");
            }
            */
            /* Test GetById
            Console.WriteLine("Veuillez indiquez un identifiant");
            Guid id = Guid.Parse(Console.ReadLine());

            Book book = service.Get(id);

            Console.WriteLine($"\"{book.Title}\" écrit par {book.Author}");
            */
            /* Test Create
            Book newBook = new Book();
            Console.WriteLine("Veuillez indiquer un titre : ");
            newBook.Title = Console.ReadLine();
            Console.WriteLine("Veuillez indiquer un Auteur : ");
            newBook.Author = Console.ReadLine();
            Console.WriteLine("Veuillez indiquer une Date de sortie : ");
            newBook.ReleaseDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Veuillez indiquer un ISBN : ");
            newBook.ISBN = Console.ReadLine();

            newBook.BookId = service.Create(newBook);

            newBook = service.Get(newBook.BookId);

            Console.WriteLine($"Livre bien ajouté le {newBook.RegisteredDate.ToShortDateString()} avec l'identifiant {newBook.BookId}");
            */

            /* Test Update 
            Console.WriteLine("Veuillez indiquez un identifiant");
            Guid id = Guid.Parse(Console.ReadLine());

            Book book = service.Get(id);

            Console.WriteLine($"\"{book.Title}\" écrit par {book.Author}\nSorti le {book.ReleaseDate.ToShortDateString()} avec l'ISBN : {book.ISBN}");

            Console.WriteLine("Veuillez indiquer un nouveau titre : ");
            book.Title = Console.ReadLine();
            Console.WriteLine("Veuillez indiquer un nouvel Auteur : ");
            book.Author = Console.ReadLine();
            Console.WriteLine("Veuillez indiquer une nouvelle Date de sortie : ");
            book.ReleaseDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Veuillez indiquer un nouvel ISBN : ");
            book.ISBN = Console.ReadLine();

            service.Update(id, book);
            book = service.Get(id);

            Console.WriteLine($"\"{book.Title}\" écrit par {book.Author}\nSorti le {book.ReleaseDate.ToShortDateString()} avec l'ISBN : {book.ISBN}");
            */
            /* Test Delete */
            Console.WriteLine("Veuillez indiquez un identifiant");
            Guid id = Guid.Parse(Console.ReadLine());

            Book book = service.Get(id);

            Console.WriteLine($"\"{book.Title}\" écrit par {book.Author}\nSorti le {book.ReleaseDate.ToShortDateString()} avec l'ISBN : {book.ISBN}");

            service.Delete(id);

            book = service.Get(id);
            Console.WriteLine($"\"{book.Title}\" écrit par {book.Author}\nSorti le {book.ReleaseDate.ToShortDateString()} avec l'ISBN : {book.ISBN}\nDésactivé le {book.DisabledDate?.ToShortDateString()}");
        }
    }
}
