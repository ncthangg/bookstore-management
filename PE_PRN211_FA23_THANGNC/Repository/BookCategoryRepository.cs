using Repository.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class BookCategoryRepository
    {
        private BookManagement2023DbContext _context;
        public List<BookCategory> GetCategories()
        {
            _context = new();
            return _context.BookCategories.ToList();
        }
    }
}
