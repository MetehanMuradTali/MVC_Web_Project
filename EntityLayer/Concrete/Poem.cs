using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Poem
    {
        [Key]
        public int PoemId { get; set; }
        [StringLength(100)]
        public string PoemName { get; set; }
        [StringLength(1000)]
        public string PoemContent { get; set; }
        public DateTime PoemDate { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}
