namespace D3
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private Form ActiveForm = null;
        public void openChaild(Form chaildForm)
        {
            if (ActiveForm != null) ActiveForm.Close();
            ActiveForm = chaildForm;
            chaildForm.TopLevel = false;
            chaildForm.FormBorderStyle = FormBorderStyle.None;
            chaildForm.Dock = DockStyle.Fill;
            panel_subforms.Controls.Add(chaildForm);
            panel_subforms.Tag = chaildForm;
            chaildForm.BringToFront();
            chaildForm.Show();
        }

        private void btn_Reg_Click(object sender, EventArgs e)
        {
            openChaild(new regesterationForm());
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            openChaild(new LoginForm(this));
        }

        private void btn_Display_Click(object sender, EventArgs e)
        {
            openChaild(new AllNewsForm());
        }
    }
}
