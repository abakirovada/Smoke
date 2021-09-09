using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smoke.Data
{
    public class Platform
    {
        [Key]
        public int PlatformId { get; set; }
        [Required]
        public string PlatformName { get; set; }
    }

    //public enum Platforms { PC, Xbox, Xbox1, ScrewMicrosoft, NintendoSwitch, Mobile }
}
