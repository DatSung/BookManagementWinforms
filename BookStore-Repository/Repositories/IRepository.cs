using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore_Repository.Repositories
{
    public interface IRepository<T>
    {
        public T Get(int Id);
        public T Get(string email);
        public List<T> GetAll();
        public void Update(T entity);
        public void Delete(int Id);
        public void Create(T entity);
    }
}
