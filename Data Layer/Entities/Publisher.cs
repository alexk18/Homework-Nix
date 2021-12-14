using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Data_Layer.Entities
{
    class Publisher
    {
        [Required]
        [StringLength(15)]
        private string Name { get; set; }
        private string Description { get; set; }
        [Required]
        private string Contact { get; set; }
    }
}
