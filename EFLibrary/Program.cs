using EFLibrary.DAL;
using EFLibrary.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.Internal;

namespace EFLibrary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //AddGenre(new Genre()
            //{
            //    Name = "Dram"

            //});


            //AddBook(new Book()
            //{
            //    Name = "Idiot",
            //    SalePrice = 25,
            //    CostPrice = 10,
            //    GenreId = 1

            //});


            //UpdateBook(new Book()
            //{
            //    Id = 3,
            //    Name = "Karamazov qardashlari",
            //    SalePrice = 21,
            //    CostPrice = 9,
            //    GenreId = 1
            //});
                
          

            //Console.WriteLine(GetBookById(1).Name);

            //Console.WriteLine(GetBookById(1).Genre.Name);   

            //var books = GetAllBooks();

            //foreach (var book in books) 
            //{
            //    Console.WriteLine(book);
            //}

            //DeleteBook(1);



        }

        static void AddBook(Book book) 
        {
            LibraryDBContex libraryDBContex = new LibraryDBContex();
            libraryDBContex.Books.Add(book);
            libraryDBContex.SaveChanges();
        }

        static Book GetBookById(int id)
        {
            LibraryDBContex libraryDBContex = new LibraryDBContex();
            var data = libraryDBContex.Books.Include(x=>x.Genre).FirstOrDefault(x=>x.Id ==id);
            libraryDBContex.SaveChanges();
            return data;

        }
        static List<Book> GetAllBooks()
        {
            LibraryDBContex libraryDBContex = new LibraryDBContex();
            return libraryDBContex.Books.Include("Genre").ToList();
        }
        static void UpdateBook(Book book)
        {
            LibraryDBContex libraryDBContex = new LibraryDBContex();
            var existbook = libraryDBContex.Books.Find(book.Id);
            if (existbook == null)
            {
                throw new NullReferenceException();
            }
            else
            {
                existbook.Name = book.Name;
                existbook.CostPrice = book.CostPrice;
                existbook.SalePrice = book.SalePrice;
                existbook.GenreId = book.GenreId;
            }

            libraryDBContex.SaveChanges();

        }

        static void DeleteBook(int id)
        {
            LibraryDBContex libraryDBContex = new LibraryDBContex();
            Book wantedbook = libraryDBContex.Books.Find(id);
            if (wantedbook == null)
            {
                throw new NullReferenceException();
            }
            else
            {
                libraryDBContex.Books.Remove(wantedbook);
            }

            libraryDBContex.SaveChanges();
        }

        static void AddGenre(Genre genre)
        {
            LibraryDBContex libraryDBContex = new LibraryDBContex();
            libraryDBContex.Genres.Add(genre);
            libraryDBContex.SaveChanges();
        }
       

        static Genre GetGenreById(int id)
        {
            LibraryDBContex libraryDBContex = new LibraryDBContex();
            var data = libraryDBContex.Genres.Find(id);
            libraryDBContex.SaveChanges();
            return data;

        }

        static List<Genre> GetAllGenres()
        {
            LibraryDBContex libraryDBContex = new LibraryDBContex();
            return libraryDBContex.Genres.ToList();
        }



        static void UpdateGenre(Genre genre)
        {
            LibraryDBContex libraryDBContex = new LibraryDBContex();
            var existgenre= libraryDBContex.Genres.Find(genre.Id);
            if (existgenre == null)
            {
                throw new NullReferenceException();
            }
            else
            {
                existgenre.Name = genre.Name;
            }

            libraryDBContex.SaveChanges();

        }


        static void DeleteGenre(int id)
        {
            LibraryDBContex libraryDBContex = new LibraryDBContex();
            Genre wantedgenre = libraryDBContex.Genres.Find(id);
            if (wantedgenre == null)
            {
                throw new NullReferenceException();
            }
            else
            {
                libraryDBContex.Genres.Remove(wantedgenre);
            }

            libraryDBContex.SaveChanges();
        }           



    }
}
