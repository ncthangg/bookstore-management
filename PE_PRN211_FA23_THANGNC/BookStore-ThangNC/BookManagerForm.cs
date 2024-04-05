using Microsoft.EntityFrameworkCore.ValueGeneration.Internal;
using Repository.Entities;
using Service;

namespace BookStore_ThangNC
{
    public partial class BookManagerForm : Form
    {
        private Book _selected = null;

        BookService _BookService = new BookService();
        BookCategoryService _CategoryService = new BookCategoryService();

        public BookManagerForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show("Do you want to Exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (answer == DialogResult.Yes)
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

            dgvBookList.DataSource = null;
            dgvBookList.DataSource = _BookService.ListAllBook();

            dgvBookList.Columns["BookCategory"].Visible = false;

            cboCategory.DataSource = _CategoryService.ListAllCategory();
            cboCategory.DisplayMember = "BookGenreType";
            cboCategory.ValueMember = "BookCategoryId";
        }

        private void dgvBookList_SelectionChanged(object sender, EventArgs e)
        {
            //Ng??i dùng có th? ch?n 1 dòng hay nhi?u dòng, n?u có thì l?y dòng ??u tiên
            if (dgvBookList.SelectedRows.Count > 0)
            {
                var _selected = (Book)dgvBookList.SelectedRows[0].DataBoundItem;

                txtId.Text = _selected.BookId.ToString();
                txtId.Enabled = false;
                txtName.Text = _selected.BookName;
                txtDescription.Text = _selected.Description;
                txtAuthor.Text = _selected.Author;
                txtPrice.Text = _selected.Price.ToString();
                txtQuantity.Text = _selected.Quantity.ToString();
                cboCategory.SelectedValue = _selected.BookCategoryId;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvBookList.DataSource = null;
            dgvBookList.DataSource = _BookService.SearchBook(txtKeyWord.Text);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            BookDetailForm f = new BookDetailForm();
            f.ShowDialog();

            // refesh sau khi Add book thanh cong
            dgvBookList.DataSource = null;
            dgvBookList.DataSource = _BookService.ListAllBook();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvBookList.SelectedRows.Count > 0)
            {
                var _selected = (Book)dgvBookList.SelectedRows[0].DataBoundItem;

                if (_selected != null)
                {
                    BookDetailForm f = new BookDetailForm();
                    f.SelectedBook = _selected;
                    f.ShowDialog();
                }
                dgvBookList.DataSource = null;
                dgvBookList.DataSource = _BookService.ListAllBook();

            }
            else
            {
                MessageBox.Show("Please choose a Book!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id;
            if (string.IsNullOrWhiteSpace(txtId.Text) || !int.TryParse(txtId.Text, out id))
            {
                MessageBox.Show("sad","error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _BookService.DeleteBook(id);
            
            dgvBookList.DataSource = null;
            dgvBookList.DataSource = _BookService.ListAllBook();
        }
    }
}
