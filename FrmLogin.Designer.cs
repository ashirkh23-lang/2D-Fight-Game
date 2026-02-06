namespace _2D_Fight_Game
{
    partial class FrmLogin
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
            btn_MainMenu = new Button();
            btn_login = new Button();
            txtbox_password = new TextBox();
            label2 = new Label();
            txtbox_username = new TextBox();
            label1 = new Label();
            Login = new Label();
            SuspendLayout();
            // 
            // btn_MainMenu
            // 
            btn_MainMenu.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_MainMenu.Location = new Point(734, 33);
            btn_MainMenu.Margin = new Padding(3, 4, 3, 4);
            btn_MainMenu.Name = "btn_MainMenu";
            btn_MainMenu.Size = new Size(142, 69);
            btn_MainMenu.TabIndex = 13;
            btn_MainMenu.Text = "Back to Main Menu";
            btn_MainMenu.UseVisualStyleBackColor = true;
            btn_MainMenu.Click += btn_MainMenu_Click;
            // 
            // btn_login
            // 
            btn_login.Cursor = Cursors.Hand;
            btn_login.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_login.Location = new Point(331, 409);
            btn_login.Margin = new Padding(3, 4, 3, 4);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(253, 72);
            btn_login.TabIndex = 12;
            btn_login.Text = "LOGIN";
            btn_login.UseVisualStyleBackColor = true;
            btn_login.Click += btn_login_Click;
            // 
            // txtbox_password
            // 
            txtbox_password.Cursor = Cursors.IBeam;
            txtbox_password.Location = new Point(352, 301);
            txtbox_password.Margin = new Padding(3, 4, 3, 4);
            txtbox_password.Name = "txtbox_password";
            txtbox_password.Size = new Size(195, 27);
            txtbox_password.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(240, 304);
            label2.Name = "label2";
            label2.Size = new Size(97, 28);
            label2.TabIndex = 10;
            label2.Text = "Password:";
            // 
            // txtbox_username
            // 
            txtbox_username.Cursor = Cursors.IBeam;
            txtbox_username.Location = new Point(352, 188);
            txtbox_username.Margin = new Padding(3, 4, 3, 4);
            txtbox_username.Name = "txtbox_username";
            txtbox_username.Size = new Size(195, 27);
            txtbox_username.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(234, 191);
            label1.Name = "label1";
            label1.Size = new Size(103, 28);
            label1.TabIndex = 8;
            label1.Text = "Username:";
            // 
            // Login
            // 
            Login.AutoSize = true;
            Login.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Login.Location = new Point(389, 93);
            Login.Name = "Login";
            Login.Size = new Size(120, 46);
            Login.TabIndex = 7;
            Login.Text = "Log In";
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(btn_MainMenu);
            Controls.Add(btn_login);
            Controls.Add(txtbox_password);
            Controls.Add(label2);
            Controls.Add(txtbox_username);
            Controls.Add(label1);
            Controls.Add(Login);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmLogin";
            Text = "FrmLogin";
            Load += FrmLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_MainMenu;
        private Button btn_login;
        private TextBox txtbox_password;
        private Label label2;
        private TextBox txtbox_username;
        private Label label1;
        private Label Login;
    }
}