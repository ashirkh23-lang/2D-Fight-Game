namespace _2D_Fight_Game
{
    partial class FrmSignIn
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
            Signin = new Label();
            label1 = new Label();
            txtbox_username = new TextBox();
            label2 = new Label();
            txtbox_password = new TextBox();
            btn_register = new Button();
            btn_MainMenu = new Button();
            SuspendLayout();
            // 
            // Signin
            // 
            Signin.AutoSize = true;
            Signin.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Signin.Location = new Point(387, 89);
            Signin.Name = "Signin";
            Signin.Size = new Size(132, 46);
            Signin.TabIndex = 0;
            Signin.Text = "Sign In\r\n";
            Signin.Click += Signin_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(233, 187);
            label1.Name = "label1";
            label1.Size = new Size(103, 28);
            label1.TabIndex = 1;
            label1.Text = "Username:";
            // 
            // txtbox_username
            // 
            txtbox_username.Cursor = Cursors.IBeam;
            txtbox_username.Location = new Point(351, 184);
            txtbox_username.Margin = new Padding(3, 4, 3, 4);
            txtbox_username.Name = "txtbox_username";
            txtbox_username.Size = new Size(195, 27);
            txtbox_username.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(239, 300);
            label2.Name = "label2";
            label2.Size = new Size(97, 28);
            label2.TabIndex = 3;
            label2.Text = "Password:";
            label2.Click += label2_Click;
            // 
            // txtbox_password
            // 
            txtbox_password.Cursor = Cursors.IBeam;
            txtbox_password.Location = new Point(351, 297);
            txtbox_password.Margin = new Padding(3, 4, 3, 4);
            txtbox_password.Name = "txtbox_password";
            txtbox_password.Size = new Size(195, 27);
            txtbox_password.TabIndex = 4;
            // 
            // btn_register
            // 
            btn_register.Cursor = Cursors.Hand;
            btn_register.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_register.Location = new Point(330, 405);
            btn_register.Margin = new Padding(3, 4, 3, 4);
            btn_register.Name = "btn_register";
            btn_register.Size = new Size(253, 72);
            btn_register.TabIndex = 5;
            btn_register.Text = "REGISTER";
            btn_register.UseVisualStyleBackColor = true;
            btn_register.Click += btn_register_Click;
            // 
            // btn_MainMenu
            // 
            btn_MainMenu.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_MainMenu.Location = new Point(733, 29);
            btn_MainMenu.Margin = new Padding(3, 4, 3, 4);
            btn_MainMenu.Name = "btn_MainMenu";
            btn_MainMenu.Size = new Size(142, 69);
            btn_MainMenu.TabIndex = 6;
            btn_MainMenu.Text = "Back to Main Menu";
            btn_MainMenu.UseVisualStyleBackColor = true;
            btn_MainMenu.Click += btn_MainMenu_Click;
            // 
            // FrmSignIn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(btn_MainMenu);
            Controls.Add(btn_register);
            Controls.Add(txtbox_password);
            Controls.Add(label2);
            Controls.Add(txtbox_username);
            Controls.Add(label1);
            Controls.Add(Signin);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmSignIn";
            Text = "FrmSignIn";
            Load += FrmSignIn_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Signin;
        private Label label1;
        private TextBox txtbox_username;
        private Label label2;
        private TextBox txtbox_password;
        private Button btn_register;
        private Button btn_MainMenu;
    }
}