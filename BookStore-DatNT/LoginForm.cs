using BookStore_Repository.Entities;
using BookStore_Service;
using System.Configuration;

namespace BookStore_DatNT
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password)) 
            {
                MessageBox.Show("Your credentials is empty!", "Empty credentials", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            IService<BookManagementMember> service = new BookManagementMemberService();
            BookManagementMember? account = new BookManagementMember();
            account = service.CheckLogin(email, password);

            if (account == null)
            {
                MessageBox.Show("Login failed. Please check your credentials","Wrong credentials", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //Not null roi, va ngon roi thi cho vao form

            if (account.MemberRole != 1) 
            {
                MessageBox.Show("You are not allowed to access this function!","Access denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //ngon roi, role admin thi mo form cho vao
            this.Hide(); //an form login
            BookManagerForm bookManagerForm = new BookManagerForm(); //tao form moi
            bookManagerForm.Show(); //show form moi len

        }
    }
}
