﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        [StringLength(100)]
        public string CategoryName { get; set; }
        public bool CategoryStatus { get; set; }

        public ICollection<Poem> Poems { get; set; }
        public ICollection<New> News { get; set; }
    }
}
