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
    public partial class AllNewsForm : Form
    {
        public AllNewsForm()
        {
            InitializeComponent();
            addDvgSource();
        }
        private void addDvgSource()
        {
            using (NewsContext context = new NewsContext())
            {
                dvg_News.DataSource = context.News
                    .Select(n => new
                    {
                        Title = n.title,
                        Description = n.description,
                        Bref = n.bref,
                        Author = n.author.name,
                        Catalog = n.catalog.name,
                    }).ToList();
                    
            }
        }
    }
}
