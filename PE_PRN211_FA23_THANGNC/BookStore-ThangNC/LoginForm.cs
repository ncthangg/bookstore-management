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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string password = txtPassword.Text;
            BookManagementMemberService sr = new BookManagementMemberService();
            BookManagementMember account = sr.CheckLogin(email, password);
            if (account == null)
            {
                DialogResult result = MessageBox.Show("Wrong Email or Password", "SignIn unsuccesfully", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (account.MemberRole != "Admin")
            {
                DialogResult result = MessageBox.Show("Not true role!","Role",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                return;

            }
            this.Hide();
            BookManagerForm bookManagerForm = new BookManagerForm();
            bookManagerForm.ShowDialog();


        }

    }
}
