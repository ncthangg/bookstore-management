using Repository.Entities;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class BookService
    {
        private BookRepository _re = new BookRepository();
        public List<Book> ListAllBook()
        {
            return _re.GetBook();
        }
        public List<Book> SearchBook(string keyword) {
            return _re.GetBook().Where(x => x.BookName.ToLower().Contains(keyword.ToLower())).ToList();
            
        }
        public void DeleteBook(int id)
        {
            _re.Delete(id);
        }
        
        public void AddBook(Book book)
        {
            _re.Create(book);
        }

        public void UpdateBook(Book book)
        {
            _re.Update(book);
        }
    }
}
