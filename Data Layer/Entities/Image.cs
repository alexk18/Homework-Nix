using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Data_Layer.Entities
{
    class Image
    {
        [Required]
        [Key]
        public Guid ImageId { get; set; }
        public string Name { get; set; }
    }
}
