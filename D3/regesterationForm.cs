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
using D3.Migrations;

namespace D3
{

    public partial class regesterationForm : Form
    {
        
        public regesterationForm()
        {
            InitializeComponent();
        }
        private bool isValidData()
        {

            return txt_Name.Text != "" && txt_UName.Text != "" && txt_pass.Text != "";
        }
        private void addNewAuthor(string name, string userName, string pass)
        {
            using (NewsContext context = new NewsContext())
            {
                Author newAuthor = new Author
                {
                    name = name,
                    user_name = userName,
                    password = pass,
                    join_date = DateOnly.FromDateTime(DateTime.Now.Date),
                    time = new TimeOnly(DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second)
                };
                context.Authors.Add(newAuthor);
                context.SaveChanges();
            }

        }
        private bool isUserNameExisted(string userName)
        {
            using (NewsContext context = new NewsContext())
            {
                Author author = context.Authors.FirstOrDefault(a => a.user_name == userName );
                return author != null; 
            }
        }

        private void btn_Reg_Click(object sender, EventArgs e)
        {
            string name = txt_Name.Text;
            string user_name = txt_UName.Text;
            string pass = txt_pass.Text;

            if (isValidData())
            {
                if (isUserNameExisted(user_name)) MessageBox.Show("that username is used before");
                else 
                {
                    addNewAuthor(name, user_name, pass);
                    MessageBox.Show("Registeration has done Successfully press login button to login");
                } 
            }
            else MessageBox.Show("please fill all fields");
        }
    }
}
