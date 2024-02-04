using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D3.Models
{
    public class New
    {
        public int id { get; set; }
        [Required]
        public string title { get; set; }
        [Required]
        public string bref { get; set; }
        [Required]
        public string description { get; set; }
        [ForeignKey("catalog")]
        public int cat_id { get; set; }
        [ForeignKey("author")]
        public int author_id { get; set; }


        public virtual Catalog catalog { get; set; }
        public virtual Author author { get; set; }


    }
}
