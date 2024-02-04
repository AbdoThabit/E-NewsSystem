using D3.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using Microsoft.Identity.Client;
namespace D3
{

    public partial class ProfileForm : Form
    {
        private int Author_id, New_ID;

        public ProfileForm(int _id)
        {
            InitializeComponent();
            Author_id = _id;
            makeCleanView();
            
            

        }
        private void makeCleanView()
        {
            showEditBtns(false);
            addCB_Source();
            addDvgSource();
            emptyFields();
        }
        private void emptyFields()
        {
            txt_title.Text = "";
            rt_Bref.Text = "";
            rt_Description.Text = "";
            cb_Catalogs.SelectedValue = -1;

        }
        private void showEditBtns(bool show)
        {
            if (show)
            {
                btn_Add.Visible = false;
                btn_delete.Visible = true;
                btn_Update.Visible = true;
            }
            else
            {
                btn_Add.Visible = true;
                btn_delete.Visible = false;
                btn_Update.Visible = false;
            }
        }
        #region Binding data 
        private void addCB_Source()
        {
            using (NewsContext context = new NewsContext())
            {
                cb_Catalogs.DataSource = context.catalogs.ToList();
                cb_Catalogs.DisplayMember = "name";
                cb_Catalogs.ValueMember = "id";
            }
        }
        private void addDvgSource()
        {
            using (NewsContext context = new NewsContext())
            {
                dvg_News.DataSource = context.News.Where(n => n.author_id == Author_id)
                    .Select(n => new
                    {
                      NewID =  n.id,
                      NewTitle = n.title,
                      NewBref =  n.bref,
                      NewDescription =  n.description
                    }).ToList();
            }
        }
        #endregion
        
        #region Adding Catalogs (only one time)
        private bool cataolgExisted(string catalogname)
        {
            using (NewsContext context = new NewsContext())
            {
                Catalog catalog = context.catalogs.FirstOrDefault(c => c.name == catalogname);
                return catalog != null;
            }
        }

        private void addCatalogs()
        {

            Catalog c1 = new Catalog()
            {
                name = "Sport",
                description = "Some good Articles about Sports"
            };
            Catalog c2 = new Catalog()
            {
                name = "Technology",
                description = "Some good Articles about Technology"
            };
            Catalog c3 = new Catalog()
            {
                name = "Fashion",
                description = "Some good Articles about Fashion"
            };
            using (NewsContext context = new NewsContext())
            {
                if (!cataolgExisted(c1.name)) context.catalogs.Add(c1);
                if (!cataolgExisted(c2.name)) context.catalogs.Add(c2);
                if (!cataolgExisted(c3.name)) context.catalogs.Add(c3);
                context.SaveChanges();
            }
        }


        #endregion


        private void dvg_News_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            showEditBtns(true);
            New_ID = (int)dvg_News.SelectedRows[0].Cells[0].Value;
            New n;
            using (NewsContext context = new NewsContext())
            {
                n = context.News.Where(n => n.id == New_ID).FirstOrDefault();
            }
            txt_title.Text = n.title;
            rt_Bref.Text = n.bref;
            rt_Description.Text = n.description;
            cb_Catalogs.SelectedValue = n.cat_id;

        }
        #region Manage Data(add,update,delete)
        private bool isValidData()
        {
            return txt_title.Text != "" && rt_Bref.Text != "" && rt_Description.Text != "" && (int)cb_Catalogs.SelectedValue != -1;
        }
        private void addNew(string _title, string _bref, string _description, int _catalog_Id, int _author_id)
        {
            New new1 = new New() { title = _title, bref = _bref, description = _description, author_id = _author_id, cat_id = _catalog_Id };
            using (NewsContext context = new NewsContext())
            {
                context.News.Add(new1);
                context.SaveChanges();
            }
        }
        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (isValidData())
            {
                string title = txt_title.Text;
                string bref = rt_Bref.Text;
                string description = rt_Description.Text;
                int catalogId = (int)cb_Catalogs.SelectedValue;
                addNew(title, bref, description, catalogId, Author_id);
                MessageBox.Show("DATA added successfully");
                makeCleanView();
            }
            else
            {
                MessageBox.Show("fill all fields");
                addDvgSource();
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
           
            using (NewsContext context = new NewsContext())
            {
                New n = context.News.Where(n => n.id == New_ID).FirstOrDefault();
                n.title = txt_title.Text;
                n.bref = rt_Bref.Text;
                n.description = rt_Description.Text;
                n.cat_id = (int)cb_Catalogs.SelectedValue;
                context.SaveChanges();
                MessageBox.Show("DATA updated successfully");
                makeCleanView();

            }


        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            
            using (NewsContext context = new NewsContext())
            {
                New n = context.News.Where(n => n.id == New_ID).FirstOrDefault();
                context.News.Remove(n);
                context.SaveChanges();
                MessageBox.Show("DATA Deleted successfully");
                makeCleanView();
            }
        }
        #endregion
    }
}
