using Microsoft.EntityFrameworkCore;
using Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class BookRepository
    {
        private BookManagement2023DbContext _context;
        public List<Book> GetBook()
        {
            _context = new();
            //return _context.Books.ToList();
            return _context.Books.Include(cat => cat.BookCategory).ToList();
        }

        public void Create(Book book)
        {
            _context = new();
            _context.Books.Add(book);
            _context.SaveChanges();
        }

        public void Update(Book book)
        {
            _context = new();
            _context.Books.Update(book);
            _context.SaveChanges();
        }
        public void Delete(int id)
        {
            _context = new();
            var book = _context.Books.FirstOrDefault(b => b.BookId == id);
            if (book != null)
            {
                _context.Books.Remove(book);
                _context.SaveChanges();
            }
        }

    }
}
