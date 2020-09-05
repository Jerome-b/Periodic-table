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
        public int id { get; set; }

        [Required]
        public int AtomicNumber { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Symbol { get; set; }

        public string Link { get; set; }
        
        [Required]
        public float AtomicWeight { get; set; }

        [Required]
        public int MolarMass { get; set; }

        public string Color { get; set; }



    }
}
