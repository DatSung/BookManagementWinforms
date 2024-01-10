namespace BookStore_DatNT
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tblEmail = new Label();
            lblPassword = new Label();
            btnLogin = new Button();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            grbLogin = new GroupBox();
            lblTitle = new Label();
            grbLogin.SuspendLayout();
            SuspendLayout();
            // 
            // tblEmail
            // 
            tblEmail.AutoSize = true;
            tblEmail.Location = new Point(49, 79);
            tblEmail.Name = "tblEmail";
            tblEmail.Size = new Size(76, 32);
            tblEmail.TabIndex = 0;
            tblEmail.Text = "Email:";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(49, 141);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(116, 32);
            lblPassword.TabIndex = 1;
            lblPassword.Text = "Password:";
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(457, 196);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(150, 46);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Sign in";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(191, 72);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(416, 39);
            txtEmail.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(191, 134);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(416, 39);
            txtPassword.TabIndex = 4;
            txtPassword.TextChanged += textBox2_TextChanged;
            // 
            // grbLogin
            // 
            grbLogin.Controls.Add(txtPassword);
            grbLogin.Controls.Add(txtEmail);
            grbLogin.Controls.Add(btnLogin);
            grbLogin.Controls.Add(lblPassword);
            grbLogin.Controls.Add(tblEmail);
            grbLogin.Location = new Point(65, 118);
            grbLogin.Name = "grbLogin";
            grbLogin.Size = new Size(666, 270);
            grbLogin.TabIndex = 5;
            grbLogin.TabStop = false;
            grbLogin.Text = "Login";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.Location = new Point(187, 40);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(430, 45);
            lblTitle.TabIndex = 6;
            lblTitle.Text = "Welcome to Book Manager";
            // 
            // LoginForm
            // 
            AcceptButton = btnLogin;
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblTitle);
            Controls.Add(grbLogin);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            grbLogin.ResumeLayout(false);
            grbLogin.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label tblEmail;
        private Label lblPassword;
        private Button btnLogin;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private GroupBox grbLogin;
        private Label lblTitle;
    }
}
