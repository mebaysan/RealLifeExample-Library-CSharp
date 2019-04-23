using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class BookDal
    {
        public List<Book> GetAll()
        {
            using(LibraryContext libraryContext = new LibraryContext())
            {
                return libraryContext.Book.ToList();
            }
        }

        public void Add(Book book)
        {
            using ( LibraryContext libraryContext = new LibraryContext())
            {
                libraryContext.Book.Add(book);
                libraryContext.SaveChanges();
            }
        }
        public void Delete(Book book)
        {
            using (LibraryContext libraryContext = new LibraryContext())
            {
                var entity = libraryContext.Entry(book);
                entity.State = EntityState.Deleted;
                libraryContext.SaveChanges();

            }
        }
        public void Update(Book book)
        {
            using (LibraryContext libraryContext = new LibraryContext())
            {
                var entity = libraryContext.Entry(book);
                entity.State = EntityState.Modified;
                libraryContext.SaveChanges();

            }
        }
        public List<Book> GetByName(string key) // direk veritabanına attık
        {
            using (LibraryContext libraryContext = new LibraryContext())
            {
                return libraryContext.Book.Where(p=> p.name.Contains(key)).ToList();
            }
        }
        public List<Book> GetByType(int typeId) 
        {
            using (LibraryContext libraryContext = new LibraryContext())
            {
                return libraryContext.Book.Where(p => p.type == typeId).ToList();
            }
        }

        public List<Book> GetByProp(int _id)
        {
            using (LibraryContext libraryContext = new LibraryContext())
            {
                return libraryContext.Book.Where(p => p.id == _id).ToList();
            }
        }





    }
}
