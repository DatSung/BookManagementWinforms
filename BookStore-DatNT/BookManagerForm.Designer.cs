namespace BookStore_DatNT
{
    partial class BookManagerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtId = new TextBox();
            txtName = new TextBox();
            txtSearch = new TextBox();
            dgvBookList = new DataGridView();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnExit = new Button();
            btnSearch = new Button();
            grbTask = new GroupBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            grbBookInfo = new GroupBox();
            cbbCategory = new ComboBox();
            txtDescription = new TextBox();
            txtAuthor = new TextBox();
            txtPrice = new TextBox();
            txtQuantity = new TextBox();
            dtpReleaseDate = new DateTimePicker();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            lblSearchName = new Label();
            grbSearch = new GroupBox();
            lblBookList = new Label();
            lblTittle = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvBookList).BeginInit();
            grbTask.SuspendLayout();
            grbBookInfo.SuspendLayout();
            grbSearch.SuspendLayout();
            SuspendLayout();
            // 
            // txtId
            // 
            txtId.Location = new Point(290, 68);
            txtId.Name = "txtId";
            txtId.Size = new Size(466, 39);
            txtId.TabIndex = 1;
            // 
            // txtName
            // 
            txtName.Location = new Point(290, 151);
            txtName.Name = "txtName";
            txtName.Size = new Size(466, 39);
            txtName.TabIndex = 3;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(138, 43);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(350, 39);
            txtSearch.TabIndex = 1;
            // 
            // dgvBookList
            // 
            dgvBookList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBookList.Location = new Point(868, 234);
            dgvBookList.Name = "dgvBookList";
            dgvBookList.RowHeadersWidth = 82;
            dgvBookList.RowTemplate.Height = 41;
            dgvBookList.Size = new Size(870, 946);
            dgvBookList.TabIndex = 5;
            dgvBookList.SelectionChanged += dgvBookList_SelectionChanged;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(23, 56);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(150, 46);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(231, 56);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(150, 46);
            btnUpdate.TabIndex = 1;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(443, 56);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(150, 46);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(651, 56);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(150, 46);
            btnExit.TabIndex = 3;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(512, 39);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(150, 46);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // grbTask
            // 
            grbTask.Controls.Add(btnExit);
            grbTask.Controls.Add(btnDelete);
            grbTask.Controls.Add(btnUpdate);
            grbTask.Controls.Add(btnAdd);
            grbTask.Location = new Point(12, 1048);
            grbTask.Name = "grbTask";
            grbTask.Size = new Size(824, 132);
            grbTask.TabIndex = 2;
            grbTask.TabStop = false;
            grbTask.Text = "Task";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(72, 75);
            label1.Name = "label1";
            label1.Size = new Size(42, 32);
            label1.TabIndex = 0;
            label1.Text = "ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(72, 158);
            label2.Name = "label2";
            label2.Size = new Size(83, 32);
            label2.TabIndex = 2;
            label2.Text = "Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(72, 849);
            label3.Name = "label3";
            label3.Size = new Size(115, 32);
            label3.TabIndex = 14;
            label3.Text = "Category:";
            label3.Click += label3_Click;
            // 
            // grbBookInfo
            // 
            grbBookInfo.Controls.Add(cbbCategory);
            grbBookInfo.Controls.Add(txtDescription);
            grbBookInfo.Controls.Add(txtAuthor);
            grbBookInfo.Controls.Add(txtPrice);
            grbBookInfo.Controls.Add(txtQuantity);
            grbBookInfo.Controls.Add(dtpReleaseDate);
            grbBookInfo.Controls.Add(label11);
            grbBookInfo.Controls.Add(label10);
            grbBookInfo.Controls.Add(label9);
            grbBookInfo.Controls.Add(label8);
            grbBookInfo.Controls.Add(label7);
            grbBookInfo.Controls.Add(label3);
            grbBookInfo.Controls.Add(label2);
            grbBookInfo.Controls.Add(label1);
            grbBookInfo.Controls.Add(txtName);
            grbBookInfo.Controls.Add(txtId);
            grbBookInfo.Location = new Point(12, 120);
            grbBookInfo.Name = "grbBookInfo";
            grbBookInfo.Size = new Size(824, 922);
            grbBookInfo.TabIndex = 1;
            grbBookInfo.TabStop = false;
            grbBookInfo.Text = "Book Info";
            // 
            // cbbCategory
            // 
            cbbCategory.FormattingEnabled = true;
            cbbCategory.Location = new Point(290, 841);
            cbbCategory.Name = "cbbCategory";
            cbbCategory.Size = new Size(466, 40);
            cbbCategory.TabIndex = 6;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(290, 243);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.ScrollBars = ScrollBars.Vertical;
            txtDescription.Size = new Size(466, 191);
            txtDescription.TabIndex = 5;
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(290, 751);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(466, 39);
            txtAuthor.TabIndex = 13;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(290, 661);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(466, 39);
            txtPrice.TabIndex = 11;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(290, 576);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(466, 39);
            txtQuantity.TabIndex = 9;
            // 
            // dtpReleaseDate
            // 
            dtpReleaseDate.Location = new Point(290, 482);
            dtpReleaseDate.Name = "dtpReleaseDate";
            dtpReleaseDate.Size = new Size(466, 39);
            dtpReleaseDate.TabIndex = 7;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(72, 758);
            label11.Name = "label11";
            label11.Size = new Size(92, 32);
            label11.TabIndex = 12;
            label11.Text = "Author:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(72, 668);
            label10.Name = "label10";
            label10.Size = new Size(70, 32);
            label10.TabIndex = 10;
            label10.Text = "Price:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(72, 583);
            label9.Name = "label9";
            label9.Size = new Size(111, 32);
            label9.TabIndex = 8;
            label9.Text = "Quantity:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(72, 482);
            label8.Name = "label8";
            label8.Size = new Size(170, 32);
            label8.TabIndex = 6;
            label8.Text = "Released Date:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(72, 250);
            label7.Name = "label7";
            label7.Size = new Size(140, 32);
            label7.TabIndex = 4;
            label7.Text = "Description:";
            // 
            // lblSearchName
            // 
            lblSearchName.AutoSize = true;
            lblSearchName.Location = new Point(35, 50);
            lblSearchName.Name = "lblSearchName";
            lblSearchName.Size = new Size(83, 32);
            lblSearchName.TabIndex = 0;
            lblSearchName.Text = "Name:";
            lblSearchName.Click += label4_Click;
            // 
            // grbSearch
            // 
            grbSearch.Controls.Add(lblSearchName);
            grbSearch.Controls.Add(btnSearch);
            grbSearch.Controls.Add(txtSearch);
            grbSearch.Location = new Point(1044, 120);
            grbSearch.Name = "grbSearch";
            grbSearch.Size = new Size(694, 108);
            grbSearch.TabIndex = 3;
            grbSearch.TabStop = false;
            grbSearch.Text = "Search";
            // 
            // lblBookList
            // 
            lblBookList.AutoSize = true;
            lblBookList.Location = new Point(868, 196);
            lblBookList.Name = "lblBookList";
            lblBookList.Size = new Size(110, 32);
            lblBookList.TabIndex = 4;
            lblBookList.Text = "Book List";
            lblBookList.Click += label5_Click;
            // 
            // lblTittle
            // 
            lblTittle.AutoSize = true;
            lblTittle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTittle.Location = new Point(243, 47);
            lblTittle.Name = "lblTittle";
            lblTittle.Size = new Size(242, 45);
            lblTittle.TabIndex = 0;
            lblTittle.Text = "Book Manager";
            // 
            // BookManagerForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1750, 1192);
            Controls.Add(lblTittle);
            Controls.Add(lblBookList);
            Controls.Add(grbSearch);
            Controls.Add(grbBookInfo);
            Controls.Add(grbTask);
            Controls.Add(dgvBookList);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "BookManagerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Book Manager";
            FormClosed += BookManagerForm_FormClosed;
            Load += BookManagerForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBookList).EndInit();
            grbTask.ResumeLayout(false);
            grbBookInfo.ResumeLayout(false);
            grbBookInfo.PerformLayout();
            grbSearch.ResumeLayout(false);
            grbSearch.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtId;
        private TextBox txtName;
        private TextBox txtSearch;
        private DataGridView dgvBookList;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnExit;
        private Button btnSearch;
        private GroupBox grbTask;
        private Label label1;
        private Label label2;
        private Label label3;
        private GroupBox grbBookInfo;
        private Label lblSearchName;
        private GroupBox grbSearch;
        private Label lblBookList;
        private Label lblTittle;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private TextBox txtPrice;
        private TextBox txtQuantity;
        private DateTimePicker dtpReleaseDate;
        private TextBox txtAuthor;
        private TextBox txtDescription;
        private ComboBox cbbCategory;
    }
}