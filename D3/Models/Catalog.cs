using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D3.Models
{
    public class Catalog
    {
        public int id { get; set; }
        [Required]
        public string  name { get; set; }
        public string description { get; set; }
        
        public virtual List<New> news { get; set; } = new List<New>();


    }
}
