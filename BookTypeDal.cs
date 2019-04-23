using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
   public class BookTypeDal
    {
        public List<BookType> GetAll()
        {
            using(LibraryContext libraryContext = new LibraryContext())
            {
                return libraryContext.BookType.ToList();   
            }
        }

        public void Add(BookType bookType)
        {
            using(LibraryContext libraryContext = new LibraryContext())
            {
                libraryContext.BookType.Add(bookType);
                libraryContext.SaveChanges();

            }
            
        }
        public void Delete(BookType bookType)
        {
            using(LibraryContext libraryContext = new LibraryContext())
            {
                var entity = libraryContext.Entry(bookType);
                entity.State = EntityState.Deleted;
                libraryContext.SaveChanges();

            }
        }

        public void Update(Book bookType)
        {
            using(LibraryContext libraryContext = new LibraryContext())
            {
                var entity = libraryContext.Entry(bookType);
                entity.State = EntityState.Modified;
                libraryContext.SaveChanges();
            }
        }
    }
}
