namespace BookStore_ThangNC
{
    partial class BookManagerForm
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
            lblBookManager = new Label();
            grbBookInfo = new GroupBox();
            dtpReleasedDate = new DateTimePicker();
            cboCategory = new ComboBox();
            txtAuthor = new TextBox();
            txtPrice = new TextBox();
            txtQuantity = new TextBox();
            txtDescription = new TextBox();
            txtName = new TextBox();
            txtId = new TextBox();
            lblCategory = new Label();
            lblAuthor = new Label();
            lblPrice = new Label();
            lblQuantity = new Label();
            lblReleasedDate = new Label();
            lblDesciption = new Label();
            lblName = new Label();
            lblId = new Label();
            grbTask = new GroupBox();
            btnExit = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            grbSearch = new GroupBox();
            btnSearch = new Button();
            txtKeyWord = new TextBox();
            lblKeyWord = new Label();
            dgvBookList = new DataGridView();
            lblBookList = new Label();
            grbBookInfo.SuspendLayout();
            grbTask.SuspendLayout();
            grbSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBookList).BeginInit();
            SuspendLayout();
            // 
            // lblBookManager
            // 
            lblBookManager.AutoSize = true;
            lblBookManager.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBookManager.Location = new Point(12, 9);
            lblBookManager.Name = "lblBookManager";
            lblBookManager.Size = new Size(157, 23);
            lblBookManager.TabIndex = 0;
            lblBookManager.Text = "Book Manager";
            // 
            // grbBookInfo
            // 
            grbBookInfo.Controls.Add(dtpReleasedDate);
            grbBookInfo.Controls.Add(cboCategory);
            grbBookInfo.Controls.Add(txtAuthor);
            grbBookInfo.Controls.Add(txtPrice);
            grbBookInfo.Controls.Add(txtQuantity);
            grbBookInfo.Controls.Add(txtDescription);
            grbBookInfo.Controls.Add(txtName);
            grbBookInfo.Controls.Add(txtId);
            grbBookInfo.Controls.Add(lblCategory);
            grbBookInfo.Controls.Add(lblAuthor);
            grbBookInfo.Controls.Add(lblPrice);
            grbBookInfo.Controls.Add(lblQuantity);
            grbBookInfo.Controls.Add(lblReleasedDate);
            grbBookInfo.Controls.Add(lblDesciption);
            grbBookInfo.Controls.Add(lblName);
            grbBookInfo.Controls.Add(lblId);
            grbBookInfo.Location = new Point(44, 39);
            grbBookInfo.Name = "grbBookInfo";
            grbBookInfo.Size = new Size(406, 375);
            grbBookInfo.TabIndex = 1;
            grbBookInfo.TabStop = false;
            grbBookInfo.Text = "Book Info";
            // 
            // dtpReleasedDate
            // 
            dtpReleasedDate.Format = DateTimePickerFormat.Short;
            dtpReleasedDate.Location = new Point(117, 183);
            dtpReleasedDate.Name = "dtpReleasedDate";
            dtpReleasedDate.Size = new Size(113, 23);
            dtpReleasedDate.TabIndex = 3;
            dtpReleasedDate.TabStop = false;
            // 
            // cboCategory
            // 
            cboCategory.FormattingEnabled = true;
            cboCategory.Location = new Point(109, 336);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(257, 23);
            cboCategory.TabIndex = 7;
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(109, 287);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(257, 23);
            txtAuthor.TabIndex = 6;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(276, 233);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(112, 23);
            txtPrice.TabIndex = 5;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(89, 233);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(112, 23);
            txtQuantity.TabIndex = 4;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(109, 110);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.ScrollBars = ScrollBars.Vertical;
            txtDescription.Size = new Size(257, 55);
            txtDescription.TabIndex = 2;
            // 
            // txtName
            // 
            txtName.Location = new Point(109, 76);
            txtName.Name = "txtName";
            txtName.Size = new Size(257, 23);
            txtName.TabIndex = 1;
            // 
            // txtId
            // 
            txtId.Location = new Point(109, 40);
            txtId.Name = "txtId";
            txtId.Size = new Size(257, 23);
            txtId.TabIndex = 0;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(28, 336);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(55, 15);
            lblCategory.TabIndex = 8;
            lblCategory.Text = "Category";
            // 
            // lblAuthor
            // 
            lblAuthor.AutoSize = true;
            lblAuthor.Location = new Point(28, 287);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new Size(44, 15);
            lblAuthor.TabIndex = 7;
            lblAuthor.Text = "Author";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(232, 236);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(33, 15);
            lblPrice.TabIndex = 6;
            lblPrice.Text = "Price";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(28, 236);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(53, 15);
            lblQuantity.TabIndex = 5;
            lblQuantity.Text = "Quantity";
            // 
            // lblReleasedDate
            // 
            lblReleasedDate.AutoSize = true;
            lblReleasedDate.Location = new Point(28, 185);
            lblReleasedDate.Name = "lblReleasedDate";
            lblReleasedDate.Size = new Size(80, 15);
            lblReleasedDate.TabIndex = 4;
            lblReleasedDate.Text = "Released Date";
            // 
            // lblDesciption
            // 
            lblDesciption.AutoSize = true;
            lblDesciption.Location = new Point(28, 113);
            lblDesciption.Name = "lblDesciption";
            lblDesciption.Size = new Size(67, 15);
            lblDesciption.TabIndex = 3;
            lblDesciption.Text = "Description";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(28, 76);
            lblName.Name = "lblName";
            lblName.Size = new Size(39, 15);
            lblName.TabIndex = 2;
            lblName.Text = "Name";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(28, 42);
            lblId.Name = "lblId";
            lblId.Size = new Size(18, 15);
            lblId.TabIndex = 1;
            lblId.Text = "ID";
            // 
            // grbTask
            // 
            grbTask.Controls.Add(btnExit);
            grbTask.Controls.Add(btnDelete);
            grbTask.Controls.Add(btnUpdate);
            grbTask.Controls.Add(btnAdd);
            grbTask.Location = new Point(35, 453);
            grbTask.Name = "grbTask";
            grbTask.Size = new Size(419, 68);
            grbTask.TabIndex = 2;
            grbTask.TabStop = false;
            grbTask.Text = "Task";
            // 
            // btnExit
            // 
            btnExit.Location = new Point(326, 28);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(66, 27);
            btnExit.TabIndex = 3;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(228, 28);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(66, 27);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(122, 28);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(66, 27);
            btnUpdate.TabIndex = 1;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(18, 28);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(66, 27);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // grbSearch
            // 
            grbSearch.Controls.Add(btnSearch);
            grbSearch.Controls.Add(txtKeyWord);
            grbSearch.Controls.Add(lblKeyWord);
            grbSearch.Location = new Point(512, 39);
            grbSearch.Name = "grbSearch";
            grbSearch.Size = new Size(419, 68);
            grbSearch.TabIndex = 3;
            grbSearch.TabStop = false;
            grbSearch.Text = " Search ";
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(308, 25);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(66, 27);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtKeyWord
            // 
            txtKeyWord.Location = new Point(101, 29);
            txtKeyWord.Name = "txtKeyWord";
            txtKeyWord.Size = new Size(185, 23);
            txtKeyWord.TabIndex = 1;
            // 
            // lblKeyWord
            // 
            lblKeyWord.AutoSize = true;
            lblKeyWord.Location = new Point(16, 32);
            lblKeyWord.Name = "lblKeyWord";
            lblKeyWord.Size = new Size(58, 15);
            lblKeyWord.TabIndex = 0;
            lblKeyWord.Text = "Key Word";
            // 
            // dgvBookList
            // 
            dgvBookList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBookList.Location = new Point(495, 166);
            dgvBookList.Name = "dgvBookList";
            dgvBookList.RowHeadersWidth = 62;
            dgvBookList.Size = new Size(436, 342);
            dgvBookList.TabIndex = 0;
            dgvBookList.SelectionChanged += dgvBookList_SelectionChanged;
            // 
            // lblBookList
            // 
            lblBookList.AutoSize = true;
            lblBookList.Location = new Point(495, 148);
            lblBookList.Name = "lblBookList";
            lblBookList.Size = new Size(55, 15);
            lblBookList.TabIndex = 4;
            lblBookList.Text = "Book List";
            // 
            // BookManagerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 540);
            Controls.Add(lblBookList);
            Controls.Add(dgvBookList);
            Controls.Add(grbSearch);
            Controls.Add(grbTask);
            Controls.Add(grbBookInfo);
            Controls.Add(lblBookManager);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "BookManagerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Book Manager";
            FormClosed += BookManagerForm_FormClosed;
            Load += BookManagerForm_Load;
            grbBookInfo.ResumeLayout(false);
            grbBookInfo.PerformLayout();
            grbTask.ResumeLayout(false);
            grbSearch.ResumeLayout(false);
            grbSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBookList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBookManager;
        private GroupBox grbBookInfo;
        private TextBox txtAuthor;
        private TextBox txtPrice;
        private TextBox txtQuantity;
        private TextBox txtDescription;
        private TextBox txtName;
        private TextBox txtId;
        private Label lblCategory;
        private Label lblAuthor;
        private Label lblPrice;
        private Label lblQuantity;
        private Label lblReleasedDate;
        private Label lblDesciption;
        private Label lblName;
        private Label lblId;
        private GroupBox grbTask;
        private Button btnExit;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private GroupBox grbSearch;
        private Button btnSearch;
        private TextBox txtKeyWord;
        private Label lblKeyWord;
        private DataGridView dgvBookList;
        private Label lblBookList;
        private DateTimePicker dtpReleasedDate;
        private ComboBox cboCategoryId;
        private ComboBox cboCategory;
    }
}
