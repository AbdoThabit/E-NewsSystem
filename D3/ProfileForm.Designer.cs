namespace D3
{
    partial class ProfileForm
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
            dvg_News = new DataGridView();
            cb_Catalogs = new ComboBox();
            txt_title = new TextBox();
            rt_Bref = new RichTextBox();
            rt_Description = new RichTextBox();
            btn_Add = new Button();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            btn_Update = new Button();
            btn_delete = new Button();
            ((System.ComponentModel.ISupportInitialize)dvg_News).BeginInit();
            SuspendLayout();
            // 
            // dvg_News
            // 
            dvg_News.Anchor = AnchorStyles.None;
            dvg_News.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvg_News.Location = new Point(183, 174);
            dvg_News.Name = "dvg_News";
            dvg_News.Size = new Size(423, 202);
            dvg_News.TabIndex = 0;
            dvg_News.RowHeaderMouseDoubleClick += dvg_News_RowHeaderMouseDoubleClick;
            // 
            // cb_Catalogs
            // 
            cb_Catalogs.FormattingEnabled = true;
            cb_Catalogs.Location = new Point(14, 93);
            cb_Catalogs.Name = "cb_Catalogs";
            cb_Catalogs.Size = new Size(121, 23);
            cb_Catalogs.TabIndex = 1;
            // 
            // txt_title
            // 
            txt_title.Location = new Point(12, 34);
            txt_title.Name = "txt_title";
            txt_title.Size = new Size(126, 23);
            txt_title.TabIndex = 2;
            // 
            // rt_Bref
            // 
            rt_Bref.Location = new Point(170, 34);
            rt_Bref.Name = "rt_Bref";
            rt_Bref.Size = new Size(242, 78);
            rt_Bref.TabIndex = 3;
            rt_Bref.Text = "";
            // 
            // rt_Description
            // 
            rt_Description.Location = new Point(440, 34);
            rt_Description.Name = "rt_Description";
            rt_Description.Size = new Size(242, 74);
            rt_Description.TabIndex = 4;
            rt_Description.Text = "";
            // 
            // btn_Add
            // 
            btn_Add.BackColor = Color.FromArgb(45, 7, 119);
            btn_Add.Font = new Font("Segoe UI", 14F);
            btn_Add.ForeColor = Color.Transparent;
            btn_Add.Location = new Point(313, 118);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(165, 50);
            btn_Add.TabIndex = 11;
            btn_Add.Text = "Add New";
            btn_Add.UseVisualStyleBackColor = false;
            btn_Add.Click += btn_Add_Click;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(45, 7, 119);
            label3.Location = new Point(14, 1);
            label3.Name = "label3";
            label3.Size = new Size(114, 30);
            label3.TabIndex = 12;
            label3.Text = "New Title :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(45, 7, 119);
            label1.Location = new Point(15, 60);
            label1.Name = "label1";
            label1.Size = new Size(98, 30);
            label1.TabIndex = 13;
            label1.Text = "Catalog :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(45, 7, 119);
            label2.Location = new Point(484, 1);
            label2.Name = "label2";
            label2.Size = new Size(133, 30);
            label2.TabIndex = 14;
            label2.Text = "Description :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(45, 7, 119);
            label4.Location = new Point(263, 1);
            label4.Name = "label4";
            label4.Size = new Size(63, 30);
            label4.TabIndex = 15;
            label4.Text = "Bref :";
            // 
            // btn_Update
            // 
            btn_Update.BackColor = Color.FromArgb(45, 7, 119);
            btn_Update.Font = new Font("Segoe UI", 14F);
            btn_Update.ForeColor = Color.Transparent;
            btn_Update.Location = new Point(142, 118);
            btn_Update.Name = "btn_Update";
            btn_Update.Size = new Size(165, 50);
            btn_Update.TabIndex = 16;
            btn_Update.Text = "Update";
            btn_Update.UseVisualStyleBackColor = false;
            btn_Update.Click += btn_Update_Click;
            // 
            // btn_delete
            // 
            btn_delete.BackColor = Color.FromArgb(45, 7, 119);
            btn_delete.Font = new Font("Segoe UI", 14F);
            btn_delete.ForeColor = Color.Transparent;
            btn_delete.Location = new Point(484, 118);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(165, 50);
            btn_delete.TabIndex = 17;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = false;
            btn_delete.Click += btn_delete_Click;
            // 
            // ProfileForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 388);
            Controls.Add(btn_delete);
            Controls.Add(btn_Update);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(btn_Add);
            Controls.Add(rt_Description);
            Controls.Add(rt_Bref);
            Controls.Add(txt_title);
            Controls.Add(cb_Catalogs);
            Controls.Add(dvg_News);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ProfileForm";
            Text = "ProfileForm";
            ((System.ComponentModel.ISupportInitialize)dvg_News).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dvg_News;
        private ComboBox cb_Catalogs;
        private TextBox txt_title;
        private RichTextBox rt_Bref;
        private RichTextBox rt_Description;
        private Button btn_Add;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Label label3;
        private Label label1;
        private Label label2;
        private Label label4;
        private Button btn_Update;
        private Button btn_delete;
    }
}