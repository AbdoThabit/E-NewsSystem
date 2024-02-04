using D3.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace D3
{

    public partial class LoginForm : Form
    {
        private MainForm main;
        public LoginForm(MainForm _main)
        {
            this.main = _main;
            InitializeComponent();
        }
        private void openNewForm(Form f)
        {
            main.openChaild(f);
        }
        private bool isValidData()
        {
            return txt_UserName.Text != "" && txt_pass.Text != "";
        }
        private void logginguser(string userName, string pass)
        {
            using (NewsContext context = new NewsContext())
            {
                Author author = context.Authors.FirstOrDefault(a => a.user_name == userName && a.password == pass);
                if (author != null)
                {
                    openNewForm(new ProfileForm(author.id));

                }
                else MessageBox.Show("there is no users matched ");
            }
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (isValidData())
            {
                string userName = txt_UserName.Text;
                string pass = txt_pass.Text;
                logginguser(userName, pass);
            }
            else MessageBox.Show("please fill all fields");
        }
    }
}
