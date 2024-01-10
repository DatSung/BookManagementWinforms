using BookStore_Repository.Entities;
using BookStore_Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BookStore_DatNT
{
    public partial class BookManagerForm : Form
    {

        private IService<Book> _bookService;
        private IService<BookCategory> _bookCategoryService;
        //Tren mang theo chuan, Service cung lam Interface luon
        //De giup UI linh hoat dung goi Serivce khac nhau - Dependency Injection
        public BookManagerForm()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure want to exit?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void BookManagerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void BookManagerForm_Load(object sender, EventArgs e)
        {

            //Disable all txt
            txtId.ReadOnly = true;
            txtName.ReadOnly = true;
            txtAuthor.ReadOnly = true;
            txtPrice.ReadOnly = true;
            txtQuantity.ReadOnly = true;
            txtDescription.ReadOnly = true;
            dtpReleaseDate.Enabled = false;
            cbbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbCategory.Enabled = false;

            //Load danh sach Book vao grid
            _bookService = new BookService();
            var result = _bookService.GetAll();

            //Refresh luoi
            dgvBookList.DataSource = null;
            dgvBookList.DataSource = result;

            //Giau cot category di, no dang chua 1 dong cua table category
            dgvBookList.Columns["BookCategory"].Visible = false;


            //Do tong bo Category vao ComboBox hoac DropDown
            _bookCategoryService = new BookCategoryService();
            cbbCategory.DataSource = _bookCategoryService.GetAll();
            //Chi show cot name cua Category - BookGenreType
            cbbCategory.DisplayMember = "BookGenreType";
            cbbCategory.ValueMember = "BookCategoryId";
        }

        private void dgvBookList_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvBookList.SelectedRows.Count > 0)
            {
                var selectedBook = (Book)dgvBookList.SelectedRows[0].DataBoundItem;
                //Co trong tay 1 object book
                txtId.Text = selectedBook.BookId.ToString();
                txtName.Text = selectedBook.BookName;
                txtDescription.Text = selectedBook.Description;
                dtpReleaseDate.Value = selectedBook.ReleaseDate;
                txtQuantity.Text = selectedBook.Quantity.ToString();
                txtAuthor.Text = selectedBook.Author;
                txtPrice.Text = selectedBook.Price.ToString();
                cbbCategory.SelectedValue = selectedBook.BookCategoryId;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                MessageBox.Show("The search keyword is required!", "Search keyword required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dgvBookList.DataSource = null;
                dgvBookList.DataSource = _bookService.GetAll();
                return;
            }
            var result = _bookService.Search(txtSearch.Text.Trim());
            dgvBookList.DataSource = null;
            dgvBookList.DataSource = result;
            ClearTxt();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId.Text) || !int.TryParse(txtId.Text, out int bookId))
            {
                MessageBox.Show("The Book Id is required!", "Book Id keyword required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (_bookService.Get(bookId) == null)
            {
                MessageBox.Show("The book was not found!", "Book not found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }


            //Convert.ToInt32()
            //int.Parse(txtId.Text)
            _bookService.Delete(bookId);
            dgvBookList.DataSource = null;
            dgvBookList.DataSource = _bookService.GetAll();
            ClearTxt();
        }


        /// <summary>
        /// Ham nay de xoa value ton dong o cac o nhap
        /// </summary>
        private void ClearTxt()
        {
            txtId.Text = string.Empty;
            txtSearch.Text = string.Empty;
            txtDescription.Text = string.Empty;
            txtAuthor.Text = string.Empty;
            txtName.Text = string.Empty;
            txtPrice.Text = string.Empty;
            txtQuantity.Text = string.Empty;
        }

        private void RefreshGrid()
        {
            dgvBookList.DataSource = null;
            dgvBookList.DataSource = _bookService.GetAll();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId.Text) || !int.TryParse(txtId.Text, out int bookId))
            {
                MessageBox.Show("The Book Id is required!", "Book Id keyword required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (_bookService.Get(bookId) == null)
            {
                MessageBox.Show("The book was not found!", "Book not found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            BookForm bookForm = new BookForm()
            {
                BookId = int.Parse(txtId.Text),
            };
            bookForm.ShowDialog();
            RefreshGrid();
            ClearTxt();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            BookForm bookForm = new BookForm();
            bookForm.ShowDialog();
            RefreshGrid();
            ClearTxt();
        }
    }
}
