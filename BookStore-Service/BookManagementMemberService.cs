using BookStore_Repository.Entities;
using BookStore_Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore_Service
{
    public class BookManagementMemberService : IService<BookManagementMember>
    {
        public void Add(BookManagementMember Entity)
        {
            throw new NotImplementedException();
        }

        public bool CheckDuplicateId(int Id)
        {
            throw new NotImplementedException();
        }

        //class nay se choi voi ca hai ben
        //Voi UI thi no dua data cho UI render hien thien
        //Lay data tu UI tu user 
        //Xu li gi do, co the can goi repository de lam viec voi DB
        //ham cua thang nay dat ten gan voi con nguoi hon: CheckLogin()
        //repo dat ten gan database hon: Get(), Create()

        public BookManagementMember? CheckLogin(string email, string password) 
        { 
            IRepository<BookManagementMember> _repository = new BookManagementMemberRepository();
            BookManagementMember? account = _repository.Get(email);

            //if (account == null)
            //{
            //    return null; //Email khong ton tai
            //}
            
            //if (account.Password == password)
            //{
            //    return account;
            //}
            //else
            //{
            //    return null;
            //}

            return account != null && account.Password == password ? account : null;

        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public BookManagementMember Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<BookManagementMember> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<BookManagementMember> Search(string keyword)
        {
            throw new NotImplementedException();
        }

        public void Update(BookManagementMember entity)
        {
            throw new NotImplementedException();
        }
    }
}
