using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class New
    {
        [Key]
        public int NewId { get; set; }
        [StringLength(100)]
        public string NewName { get; set; }
        [StringLength(1000)]
        public string NewContent { get; set; }
        public DateTime NewDate { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}
