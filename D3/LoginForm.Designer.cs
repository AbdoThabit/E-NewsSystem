namespace D3
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
            label3 = new Label();
            label2 = new Label();
            txt_pass = new TextBox();
            txt_UserName = new TextBox();
            btn_login = new Button();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(45, 7, 119);
            label3.Location = new Point(185, 91);
            label3.Name = "label3";
            label3.Size = new Size(124, 30);
            label3.TabIndex = 9;
            label3.Text = "UserName :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(45, 7, 119);
            label2.Location = new Point(185, 178);
            label2.Name = "label2";
            label2.Size = new Size(114, 30);
            label2.TabIndex = 8;
            label2.Text = "Password :";
            // 
            // txt_pass
            // 
            txt_pass.Location = new Point(341, 185);
            txt_pass.Name = "txt_pass";
            txt_pass.Size = new Size(184, 23);
            txt_pass.TabIndex = 7;
            // 
            // txt_UserName
            // 
            txt_UserName.Location = new Point(341, 91);
            txt_UserName.Name = "txt_UserName";
            txt_UserName.Size = new Size(184, 23);
            txt_UserName.TabIndex = 6;
            // 
            // btn_login
            // 
            btn_login.BackColor = Color.FromArgb(45, 7, 119);
            btn_login.Font = new Font("Segoe UI", 14F);
            btn_login.ForeColor = Color.Transparent;
            btn_login.Location = new Point(256, 265);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(167, 65);
            btn_login.TabIndex = 10;
            btn_login.Text = "Login";
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += btn_login_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 388);
            Controls.Add(btn_login);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txt_pass);
            Controls.Add(txt_UserName);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label2;
        private TextBox txt_pass;
        private TextBox txt_UserName;
        private Button btn_login;
    }
}