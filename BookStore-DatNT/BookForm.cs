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
using System.Xml.Linq;

namespace BookStore_DatNT
{
	public partial class BookForm : Form
	{

		//Dung 1 bien Public Book hoac 1 bien int de luu trang thai form
		//neu bien nay == null thi Form ung tao moi
		//Neu bien nay != null tuc la id = ??? nao do, thi ta get() no tu DB

		public int? BookId { get; set; }

		private IService<Book> _bookService = new BookService();
		private IService<BookCategory> _bookCategoryService = new BookCategoryService();

		public BookForm()
		{
			InitializeComponent();
		}

		private void BookForm_Load(object sender, EventArgs e)
		{
			cbbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
			cbbCategory.DataSource = _bookCategoryService.GetAll();
			cbbCategory.DisplayMember = "BookGenreType";
			cbbCategory.ValueMember = "BookCategoryId";

			if (this.BookId != null)
			{
				txtId.ReadOnly = true;
				lblTitle.Text = "Update a book";
				this.Text = "Update Book";
				//edit mode, thi phai hien thi data
				//new mode, do nothing, form trong tron
				var book = _bookService.Get((int)BookId);

				txtId.Text = book.BookId.ToString();
				txtName.Text = book.BookName;
				txtDescription.Text = book.Description;
				dtpReleaseDate.Value = book.ReleaseDate;
				txtQuantity.Text = book.Quantity.ToString();
				txtAuthor.Text = book.Author;
				txtPrice.Text = book.Price.ToString();


				//Chi show cot name cua Category - BookGenreType
				cbbCategory.SelectedValue = book.BookCategoryId;
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Book book = new Book()
			{
				BookCategoryId = int.Parse(cbbCategory.SelectedValue.ToString()),
				BookName = txtName.Text.Trim(),
				Description = txtDescription.Text.Trim(),
				Author = txtAuthor.Text.Trim(),
				ReleaseDate = dtpReleaseDate.Value.Date,
				Quantity = int.Parse(txtQuantity.Text),
				BookId = int.Parse(txtId.Text),
				Price = double.Parse(txtPrice.Text),
			};

			//This is for update
			if (BookId != null)
			{

				DialogResult result = MessageBox.Show("Confirm update book.", "Confirm update", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (result == DialogResult.Yes)
				{
					_bookService.Update(book);
				}
				this.Close();
			}
			else
			{
				//This is for add
				if (_bookService.CheckDuplicateId(book.BookId))
				{
					MessageBox.Show("Your book Id is duplicated !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				else
				{
					_bookService.Add(book);
					MessageBox.Show("Add new Book successfully !", "Add success", MessageBoxButtons.OK, MessageBoxIcon.Information);
					this.Close();
				}
			}
		}

		private void cbbCategory_SelectedIndexChanged(object sender, EventArgs e)
		{

		}
	}
}
