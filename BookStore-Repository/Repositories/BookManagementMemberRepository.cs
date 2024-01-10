using BookStore_Repository.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore_Repository.Repositories
{
    public class BookManagementMemberRepository : IRepository<BookManagementMember>
    {
        private BookManagement2023DBContext _dbContext;

        public void Create(BookManagementMember entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int bookId)
        {
            throw new NotImplementedException();
        }

        //Cac ham CRUD cua table Member/Account
        //Repo bao gio cung choi voi CSDL
        //Chi chua ham CRUD co ban 
        //Ham tra ve 1 account nao do theo username/email - duy nhat trong table
        public BookManagementMember? Get(string email)
        {
            _dbContext = new BookManagement2023DBContext();
            //db dang moc vao csdl va chua san 3 table, list cac data, cho goi xai
            var result = _dbContext.BookManagementMembers.FirstOrDefault(x => x.Email == email);
            return result;
        }

        public BookManagementMember Get(int bookId)
        {
            throw new NotImplementedException();
        }

        public List<BookManagementMember> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(BookManagementMember entity)
        {
            throw new NotImplementedException();
        }
    }
}
