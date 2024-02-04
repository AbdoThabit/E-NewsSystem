namespace D3
{
    partial class MainForm
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
            panel_options = new Panel();
            btn_Display = new Button();
            btn_login = new Button();
            btn_Reg = new Button();
            panel_subforms = new Panel();
            label1 = new Label();
            panel_options.SuspendLayout();
            panel_subforms.SuspendLayout();
            SuspendLayout();
            // 
            // panel_options
            // 
            panel_options.BackColor = Color.FromArgb(186, 161, 238);
            panel_options.Controls.Add(btn_Display);
            panel_options.Controls.Add(btn_login);
            panel_options.Controls.Add(btn_Reg);
            panel_options.Dock = DockStyle.Top;
            panel_options.Location = new Point(0, 0);
            panel_options.Name = "panel_options";
            panel_options.Size = new Size(800, 65);
            panel_options.TabIndex = 0;
            // 
            // btn_Display
            // 
            btn_Display.BackColor = Color.FromArgb(45, 7, 119);
            btn_Display.Font = new Font("Segoe UI", 14F);
            btn_Display.ForeColor = Color.Transparent;
            btn_Display.Location = new Point(568, 0);
            btn_Display.Name = "btn_Display";
            btn_Display.Size = new Size(167, 65);
            btn_Display.TabIndex = 2;
            btn_Display.Text = "Display All News";
            btn_Display.UseVisualStyleBackColor = false;
            btn_Display.Click += btn_Display_Click;
            // 
            // btn_login
            // 
            btn_login.BackColor = Color.FromArgb(45, 7, 119);
            btn_login.Font = new Font("Segoe UI", 14F);
            btn_login.ForeColor = Color.Transparent;
            btn_login.Location = new Point(310, 0);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(167, 65);
            btn_login.TabIndex = 1;
            btn_login.Text = "Login";
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += btn_login_Click;
            // 
            // btn_Reg
            // 
            btn_Reg.BackColor = Color.FromArgb(45, 7, 119);
            btn_Reg.Font = new Font("Segoe UI", 14F);
            btn_Reg.ForeColor = Color.Transparent;
            btn_Reg.Location = new Point(59, 0);
            btn_Reg.Name = "btn_Reg";
            btn_Reg.Size = new Size(167, 65);
            btn_Reg.TabIndex = 0;
            btn_Reg.Text = "Registeration";
            btn_Reg.UseVisualStyleBackColor = false;
            btn_Reg.Click += btn_Reg_Click;
            // 
            // panel_subforms
            // 
            panel_subforms.Controls.Add(label1);
            panel_subforms.Dock = DockStyle.Top;
            panel_subforms.Location = new Point(0, 65);
            panel_subforms.Name = "panel_subforms";
            panel_subforms.Size = new Size(800, 388);
            panel_subforms.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F);
            label1.ForeColor = Color.FromArgb(45, 7, 119);
            label1.Location = new Point(224, 124);
            label1.Name = "label1";
            label1.Size = new Size(325, 32);
            label1.TabIndex = 0;
            label1.Text = "Welecome to E-News System";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel_subforms);
            Controls.Add(panel_options);
            Name = "MainForm";
            Text = "Form1";
            panel_options.ResumeLayout(false);
            panel_subforms.ResumeLayout(false);
            panel_subforms.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_options;
        private Button btn_Reg;
        private Panel panel_subforms;
        private Button btn_login;
        private Button btn_Display;
        private Label label1;
    }
}
