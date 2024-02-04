namespace D3
{
    partial class AllNewsForm
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
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dvg_News).BeginInit();
            SuspendLayout();
            // 
            // dvg_News
            // 
            dvg_News.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvg_News.Location = new Point(171, 92);
            dvg_News.Name = "dvg_News";
            dvg_News.Size = new Size(457, 284);
            dvg_News.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F);
            label1.ForeColor = Color.FromArgb(45, 7, 119);
            label1.Location = new Point(226, 33);
            label1.Name = "label1";
            label1.Size = new Size(295, 32);
            label1.TabIndex = 1;
            label1.Text = "Here you will find all news";
            // 
            // AllNewsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 388);
            Controls.Add(label1);
            Controls.Add(dvg_News);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AllNewsForm";
            Text = "AllNewsForm";
            ((System.ComponentModel.ISupportInitialize)dvg_News).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dvg_News;
        private Label label1;
    }
}