using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PeriodicTable.Model
{
    public class Element
    {
        [Key]
        public int AtomicNumber { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Symbol { get; set; }

    }
}
