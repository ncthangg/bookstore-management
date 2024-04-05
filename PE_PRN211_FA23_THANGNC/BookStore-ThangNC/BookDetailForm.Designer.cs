namespace BookStore_ThangNC
{
    partial class BookDetailForm
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
            lblAddUpdateBook = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            grbBookInfo.SuspendLayout();
            SuspendLayout();
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
            grbBookInfo.Location = new Point(69, 39);
            grbBookInfo.Name = "grbBookInfo";
            grbBookInfo.Size = new Size(406, 375);
            grbBookInfo.TabIndex = 3;
            grbBookInfo.TabStop = false;
            grbBookInfo.Text = "Book Info";
            // 
            // dtpReleasedDate
            // 
            dtpReleasedDate.Format = DateTimePickerFormat.Short;
            dtpReleasedDate.Location = new Point(117, 183);
            dtpReleasedDate.Name = "dtpReleasedDate";
            dtpReleasedDate.Size = new Size(113, 23);
            dtpReleasedDate.TabIndex = 17;
            dtpReleasedDate.TabStop = false;
            // 
            // cboCategory
            // 
            cboCategory.FormattingEnabled = true;
            cboCategory.Location = new Point(109, 336);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(257, 23);
            cboCategory.TabIndex = 16;
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(109, 287);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(257, 23);
            txtAuthor.TabIndex = 15;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(276, 233);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(112, 23);
            txtPrice.TabIndex = 14;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(89, 233);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(112, 23);
            txtQuantity.TabIndex = 13;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(109, 110);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.ScrollBars = ScrollBars.Vertical;
            txtDescription.Size = new Size(257, 55);
            txtDescription.TabIndex = 11;
            // 
            // txtName
            // 
            txtName.Location = new Point(109, 76);
            txtName.Name = "txtName";
            txtName.Size = new Size(257, 23);
            txtName.TabIndex = 10;
            // 
            // txtId
            // 
            txtId.Location = new Point(109, 40);
            txtId.Name = "txtId";
            txtId.Size = new Size(257, 23);
            txtId.TabIndex = 9;
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
            // lblAddUpdateBook
            // 
            lblAddUpdateBook.AutoSize = true;
            lblAddUpdateBook.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAddUpdateBook.Location = new Point(37, 9);
            lblAddUpdateBook.Name = "lblAddUpdateBook";
            lblAddUpdateBook.Size = new Size(214, 23);
            lblAddUpdateBook.TabIndex = 2;
            lblAddUpdateBook.Text = "lblAddUpdateBook";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(186, 420);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(121, 38);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(354, 420);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(121, 38);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // BookDetailForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(542, 475);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(grbBookInfo);
            Controls.Add(lblAddUpdateBook);
            Name = "BookDetailForm";
            Text = "Book Detail";
            Load += BookDetailForm_Load;
            grbBookInfo.ResumeLayout(false);
            grbBookInfo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grbBookInfo;
        private DateTimePicker dtpReleasedDate;
        private ComboBox cboCategory;
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
        private Label lblAddUpdateBook;
        private Button btnSave;
        private Button btnCancel;
    }
}