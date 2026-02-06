namespace _2D_Fight_Game
{
    partial class MainMenu
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
            btnlogin = new Button();
            btnSign = new Button();
            text_2D_Game = new TextBox();
            SuspendLayout();
            // 
            // btnlogin
            // 
            btnlogin.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnlogin.Location = new Point(345, 243);
            btnlogin.Margin = new Padding(3, 4, 3, 4);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(221, 57);
            btnlogin.TabIndex = 0;
            btnlogin.Text = "Login";
            btnlogin.UseVisualStyleBackColor = true;
            btnlogin.Click += btnlogin_Click;
            // 
            // btnSign
            // 
            btnSign.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSign.Location = new Point(347, 311);
            btnSign.Margin = new Padding(3, 4, 3, 4);
            btnSign.Name = "btnSign";
            btnSign.Size = new Size(218, 59);
            btnSign.TabIndex = 1;
            btnSign.Text = "Sign in";
            btnSign.UseVisualStyleBackColor = true;
            btnSign.Click += btnSign_Click;
            // 
            // text_2D_Game
            // 
            text_2D_Game.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            text_2D_Game.ForeColor = Color.Black;
            text_2D_Game.Location = new Point(319, 127);
            text_2D_Game.Margin = new Padding(3, 4, 3, 4);
            text_2D_Game.Name = "text_2D_Game";
            text_2D_Game.Size = new Size(279, 52);
            text_2D_Game.TabIndex = 2;
            text_2D_Game.Text = "2D Fight Game";
            text_2D_Game.TextAlign = HorizontalAlignment.Center;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(929, 615);
            Controls.Add(text_2D_Game);
            Controls.Add(btnSign);
            Controls.Add(btnlogin);
            Margin = new Padding(3, 4, 3, 4);
            Name = "MainMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainMenu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnlogin;
        private Button btnSign;
        private TextBox text_2D_Game;
    }
}
