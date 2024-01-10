using BookStore_Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore_Repository.Repositories
{

    /// <summary>
    /// Class nay dung de CRUD table category - The loai sach
    /// Thuong table nay it thay doi value
    /// chu yeu la lay ra danh sach
    /// </summary>
    public class BookCategoryRepository : IRepository<BookCategory>
    {
        private BookManagement2023DBContext _dbContext;

        public void Create(BookCategory entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int bookId)
        {
            throw new NotImplementedException();
        }

        public BookCategory Get(int bookId)
        {
            throw new NotImplementedException();
        }

        public BookCategory Get(string email)
        {
            throw new NotImplementedException();
        }

        public List<BookCategory> GetAll()
        {
            _dbContext = new BookManagement2023DBContext();
            return _dbContext.BookCategories.ToList();
        }

        public void Update(BookCategory entity)
        {
            throw new NotImplementedException();
        }
    }
}
