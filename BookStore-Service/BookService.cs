using BookStore_Repository.Entities;
using BookStore_Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore_Service
{   
    /// <summary>
    /// Class nay chua cac ham cung cap/tuong tac voi GUI FORMS
    /// Sau no no se giao tiep voi Repo tuong ung de tuong tac gian tiep voi CSDL
    /// Cac ten ham nghe no "human" hon so voi repo CRUD
    /// </summary>
    public class BookService : IService<Book>
    {
        // Can repo de CRUD xuong DB
        //Can dua ra ham de cung cap cho form
        //thang dua giua 2 ben repo va form

        private IRepository<Book> _repository = new BookRepository();

        /// <summary>
        /// Ham lay tat ca cuong sach
        /// </summary>
        /// <returns></returns>
        public List<Book> GetAll()
        {
            var result = _repository.GetAll(); 
            return result;
        }

        public List<Book> Search(string keyword) 
        {
            var result = _repository.GetAll().Where(x => x.BookName.ToLower().Contains(keyword.ToLower()) 
                || x.Description.ToLower().Contains(keyword.ToLower())).ToList();
            return result;
        }

        public void Delete(int bookId) 
        {
            _repository.Delete(bookId);
        }

        public Book Get(int bookId)
        {
            return _repository.Get(bookId);
        }

        public void Add(Book book)
        {
            _repository.Create(book);
        }

        public void Update(Book book)
        {
            _repository.Update(book);
        }

        public Book? CheckLogin(string email, string password)
        {
            throw new NotImplementedException();
        }

        public bool CheckDuplicateId(int Id)
        {
            var book = _repository.GetAll().Where(x => x.BookId == Id);
            if (book == null)
            {
                return false;
            } 
            else
            {
                return true;
            }
        }
    }
}
