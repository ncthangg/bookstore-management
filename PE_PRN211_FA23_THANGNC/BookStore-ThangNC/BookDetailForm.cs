using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using Repository.Entities;
using Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore_ThangNC
{
    public partial class BookDetailForm : Form
    {
        public Book SelectedBook { get; set; } = null;

        private BookService _bookService = new BookService();
        private BookCategoryService _categoryService = new BookCategoryService();
        public BookDetailForm()
        {
            InitializeComponent();
        }


        private void BookDetailForm_Load(object sender, EventArgs e)
        {
            lblAddUpdateBook.Text = "Add a Book";
            cboCategory.DataSource = _categoryService.ListAllCategory();
            cboCategory.DisplayMember = "BookGenreType";
            cboCategory.ValueMember = "BookCategoryId";
            if (SelectedBook != null)
            {
                txtId.Text = SelectedBook.BookId.ToString();
                txtId.Enabled = false;

                txtName.Text = SelectedBook.BookName;

                txtDescription.Text = SelectedBook.Description;

                txtAuthor.Text = SelectedBook.Author;

                txtPrice.Text = SelectedBook.Price.ToString();

                dtpReleasedDate.Text = SelectedBook.ReleaseDate.ToString();

                dtpReleasedDate.Value = SelectedBook.ReleaseDate;

                txtQuantity.Text = SelectedBook.Quantity.ToString();

                cboCategory.SelectedValue = SelectedBook.BookCategoryId;
                lblAddUpdateBook.Text = "Update a Book";
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Book book = new Book()
            {
                BookId = int.Parse(txtId.Text.Trim()),
                BookName = txtName.Text.Trim(),
                Description = txtDescription.Text.Trim(),
                Author = txtAuthor.Text.Trim(),
                ReleaseDate = dtpReleasedDate.Value.Date,
                Quantity = int.Parse(txtQuantity.Text.Trim()),
                Price = double.Parse(txtPrice.Text.Trim()),

                BookCategoryId = int.Parse(cboCategory.SelectedValue.ToString()),
            };
            if(SelectedBook != null)
            {
                _bookService.UpdateBook(book);
            }
            if (SelectedBook == null)
            {
                _bookService.AddBook(book);
            }
            Close();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }

}
