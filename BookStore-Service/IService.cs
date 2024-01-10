using BookStore_Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore_Service
{
    public interface IService<T>
    {
        public List<T> GetAll();
        public List<T> Search(string keyword);
        public T Get(int id);
        public void Delete(int id);
        public void Update(T entity);
        public void Add(T Entity);
        public T? CheckLogin(string email, string password);
        public bool CheckDuplicateId(int Id);
    }
}
