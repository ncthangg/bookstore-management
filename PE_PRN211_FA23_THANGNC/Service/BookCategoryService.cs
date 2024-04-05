using Repository;
using Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class BookCategoryService
    {
        private BookCategoryRepository _re = new BookCategoryRepository();
        public List<BookCategory> ListAllCategory()
        {
            return _re.GetCategories();
        }
    }
}
