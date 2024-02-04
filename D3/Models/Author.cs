using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D3.Models
{
    public class Author
    {
        public int id { get; set; }
        [Required]
        public string name { get; set; }
        [Required]
        public string user_name { get; set; }
        [Required]
        public string password { get; set; }
        public DateOnly join_date { get; set; }
        public TimeOnly time { get; set; }
        public virtual List<New> news { get; set; } = new List<New>();


    }
}
