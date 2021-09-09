using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smoke.Data
{
    /*public class MaturityRating
    {
        [Key]
        public int MaturityId { get; set; }

        [Required]
        public string Name { get; set; }
    }*/
    public enum MaturityRating {E, Etenplus, T, M}
}
