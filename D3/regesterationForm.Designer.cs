namespace D3
{
    partial class regesterationForm
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
            txt_Name = new TextBox();
            txt_UName = new TextBox();
            txt_pass = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btn_Reg = new Button();
            SuspendLayout();
            // 
            // txt_Name
            // 
            txt_Name.Location = new Point(371, 57);
            txt_Name.Name = "txt_Name";
            txt_Name.Size = new Size(184, 23);
            txt_Name.TabIndex = 0;
            // 
            // txt_UName
            // 
            txt_UName.Location = new Point(371, 151);
            txt_UName.Name = "txt_UName";
            txt_UName.Size = new Size(184, 23);
            txt_UName.TabIndex = 1;
            // 
            // txt_pass
            // 
            txt_pass.Location = new Point(371, 245);
            txt_pass.Name = "txt_pass";
            txt_pass.Size = new Size(184, 23);
            txt_pass.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(45, 7, 119);
            label1.Location = new Point(215, 57);
            label1.Name = "label1";
            label1.Size = new Size(81, 30);
            label1.TabIndex = 3;
            label1.Text = "Name :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(45, 7, 119);
            label2.Location = new Point(215, 245);
            label2.Name = "label2";
            label2.Size = new Size(114, 30);
            label2.TabIndex = 4;
            label2.Text = "Password :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(45, 7, 119);
            label3.Location = new Point(215, 142);
            label3.Name = "label3";
            label3.Size = new Size(124, 30);
            label3.TabIndex = 5;
            label3.Text = "UserName :";
            // 
            // btn_Reg
            // 
            btn_Reg.BackColor = Color.FromArgb(45, 7, 119);
            btn_Reg.Font = new Font("Segoe UI", 14F);
            btn_Reg.ForeColor = Color.Transparent;
            btn_Reg.Location = new Point(323, 311);
            btn_Reg.Name = "btn_Reg";
            btn_Reg.Size = new Size(167, 65);
            btn_Reg.TabIndex = 11;
            btn_Reg.Text = "Register Now!";
            btn_Reg.UseVisualStyleBackColor = false;
            btn_Reg.Click += btn_Reg_Click;
            // 
            // regesterationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 388);
            Controls.Add(btn_Reg);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_pass);
            Controls.Add(txt_UName);
            Controls.Add(txt_Name);
            FormBorderStyle = FormBorderStyle.None;
            Name = "regesterationForm";
            Text = "regesterationForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_Name;
        private TextBox txt_UName;
        private TextBox txt_pass;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btn_Reg;
    }
}