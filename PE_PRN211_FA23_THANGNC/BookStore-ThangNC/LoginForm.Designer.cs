namespace BookStore_ThangNC
{
    partial class LoginForm
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
            lblBookManagementSystem = new Label();
            lblEmail = new Label();
            lblPassword = new Label();
            lblSignIn = new Label();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            btnSignIn = new Button();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblBookManagementSystem
            // 
            lblBookManagementSystem.AutoSize = true;
            lblBookManagementSystem.Font = new Font("Showcard Gothic", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBookManagementSystem.Location = new Point(137, 30);
            lblBookManagementSystem.Name = "lblBookManagementSystem";
            lblBookManagementSystem.Size = new Size(493, 44);
            lblBookManagementSystem.TabIndex = 0;
            lblBookManagementSystem.Text = "Book Management System";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(54, 80);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(48, 21);
            lblEmail.TabIndex = 1;
            lblEmail.Text = "Email";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPassword.Location = new Point(53, 162);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(76, 21);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Password";
            // 
            // lblSignIn
            // 
            lblSignIn.AutoSize = true;
            lblSignIn.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSignIn.Location = new Point(142, 30);
            lblSignIn.Name = "lblSignIn";
            lblSignIn.Size = new Size(98, 37);
            lblSignIn.TabIndex = 3;
            lblSignIn.Text = "Sign In";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(53, 106);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(280, 33);
            txtEmail.TabIndex = 4;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(53, 186);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(280, 33);
            txtPassword.TabIndex = 5;
            // 
            // btnSignIn
            // 
            btnSignIn.Font = new Font("Showcard Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSignIn.Location = new Point(121, 244);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(136, 47);
            btnSignIn.TabIndex = 6;
            btnSignIn.Text = "Sign in";
            btnSignIn.UseVisualStyleBackColor = true;
            btnSignIn.Click += btnSignIn_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(btnSignIn);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(lblSignIn);
            panel1.Controls.Add(lblPassword);
            panel1.Controls.Add(lblEmail);
            panel1.Location = new Point(183, 86);
            panel1.Name = "panel1";
            panel1.Size = new Size(386, 332);
            panel1.TabIndex = 7;
            // 
            // LoginForm
            // 
            AcceptButton = btnSignIn;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(719, 450);
            Controls.Add(panel1);
            Controls.Add(lblBookManagementSystem);
            Name = "LoginForm";
            Text = "Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBookManagementSystem;
        private Label lblEmail;
        private Label lblPassword;
        private Label lblSignIn;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private Button btnSignIn;
        private Panel panel1;
    }
}