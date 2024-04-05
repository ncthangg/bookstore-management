using Repository;
using Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class BookManagementMemberService
    {
        private BookManagementMemberRepository _re = new BookManagementMemberRepository();
        //class này chơi với 2 bên
        //UI : đưa data cho UI hoặc lấy data từ UI (user input)
        public BookManagementMember CheckLogin(string email, string password)
        {
            BookManagementMember account = _re.Get(email);
            if (account == null)
            {
                return null;
            }
            if(account.Password == password)
            {
                return account; 
            }
            return null;
        }
    }
    
}
