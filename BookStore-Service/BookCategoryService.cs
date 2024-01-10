using BookStore_Repository.Entities;
using BookStore_Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore_Service
{
    public class BookCategoryService : IService<BookCategory>
    {
        private IRepository<BookCategory> _repository;

        public void Add(BookCategory Entity)
        {
            throw new NotImplementedException();
        }

        public bool CheckDuplicateId(int Id)
        {
            throw new NotImplementedException();
        }

        public BookCategory? CheckLogin(string email, string password)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public BookCategory Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<BookCategory> GetAll()
        {
            _repository = new BookCategoryRepository();
            return _repository.GetAll();
        }

        public List<BookCategory> Search(string keyword)
        {
            throw new NotImplementedException();
        }

        public void Update(BookCategory entity)
        {
            throw new NotImplementedException();
        }
    }
}
