using BookStore_Repository.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore_Repository.Repositories
{
    /// <summary>
    /// Day la class chiu trach nhiem tuong tac truc tiep voi csdl, voi table book
    /// Tuc la no se xai class Book dc generate boi lenh scaffold minh da lam
    /// Cac ham se la CRUD 1 cuong sach 1 instance of Book Class
    /// De tuong tac dc voi CSDL thi ta phai goi class BookManagement2023DbContext
    /// Class nay dai dien cho CSDL minhf dang su dung
    /// </summary>
    public class BookRepository : IRepository<Book>
    {
        //CRUD muc csdl, xao nau data tu csdl la viec cua thang service
        //Chuan code cho nay phai ke thua tu Interface IRepository<Entity> / IBookRepository
        //Bai bua nay khong dung interface, vi dung interface van phai code CRUD


        private BookManagement2023DBContext _dbContext;


        /// <summary>
        /// Ham nhan vao ma cuong sach la so nguyen va where va tra ve duy nhat 1 cuong sach - new Book()
        /// Phai nho den class DBContext dang co chua chuoi ket noi doc tu Json
        /// Vi ma sach co the sai, cos the k thay sach de return, ta se return null
        /// </summary>
        /// <param name="bookId"></param>
        /// <returns></returns>
        public Book? Get(int bookId)
        {
            _dbContext = new BookManagement2023DBContext();
            var result = _dbContext.Books.Include(cat => cat.BookCategory).FirstOrDefault(x => x.BookId == bookId);
            //_context.Books; tuong duong SELECT * FROM tblBook
            //Lay 1 cuon sach theo Id co 2 cach;
            //LinQ var result = _dbContext.Books.FirstOrDefault(x => x.BookId == bookId);
            //Dung ham cua List, ham Find(bookID); var result = _dbContext.Books.Find(bookId);
            return result;
        }

        /// <summary>
        /// Ham nay dung de tra ve tat cac cuon sach dang co trong table Book
        /// Return List<Book>. Can goi DBContext dang nam giu 3 table
        /// co 1 chuyen thu vi o moi quan he 1-N tring table
        /// </summary>
        /// <returns></returns>
        public List<Book> GetAll()
        {
            _dbContext = new BookManagement2023DBContext();

            /*return _dbContext.Books.ToList();*/ //Chi load thong tin Book, ko load table category
            //lam sao load dc info cua category, de sau nay con lay ten category
            //lam giong nhu cau select * from B, Cetegory where Bcatid - catid

            return _dbContext.Books.Include(cat => cat.BookCategory).ToList();
            //iner join san table bookcategory
            //qua dat tinh/thuoc tinh category o Book
        } 

        /// <summary>
        /// Ham nay tao moi 1 cuong sach va insert xuong csdl qua goi hanh dong cua DbContext va dang dc chong lung boi EF 
        /// </summary>
        /// <param name="book"></param>
        public void Create(Book book)
        {
            _dbContext = new BookManagement2023DBContext();
            _dbContext.Books.Add(book);
            _dbContext.SaveChanges();
        }

        /// <summary>
        /// Ham nay se cap nhat 1 cuong sach dang co voi cac thong tin moi
        /// </summary>
        /// <param name="book"></param>
        public void Update(Book book)
        {
            _dbContext = new BookManagement2023DBContext();
            _dbContext.Books.Update(book);
            _dbContext.SaveChanges();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bookId"></param>
        public void Delete(int  bookId) 
        {
            _dbContext = new BookManagement2023DBContext();
            var book = _dbContext.Books.FirstOrDefault(x => x.BookId == bookId);

            if (book != null)
            {               
                _dbContext.Books.Remove(book);
                _dbContext.SaveChanges();
            }
        }

        public Book Get(string name)
        {
            throw new NotImplementedException();
        }

        //public List<Book> Search(string keyword)
        //{
        // Nen de o tang service do nhu cau search khac nhau
        //}

        //Tang Repo chi nen lam nhung ham co ban CRUD data trong table
    }
}