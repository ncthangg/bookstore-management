using Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class BookManagementMemberRepository
    {
        private BookManagement2023DbContext _context;
        public BookManagementMember Get(string email)
        {
            _context = new();
            return _context.BookManagementMembers.FirstOrDefault(x => x.Email == email);
        }
    }
}
