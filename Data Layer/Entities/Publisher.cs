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
        [Key]
        public Guid PublisherId { get; set; }
        [Required(ErrorMessage = "Укажите название издателя")]
        [StringLength(15, ErrorMessage = "Название большое")]
        public string Name { get; set; }
        public string Description { get; set; }
        [Required]
        public string Contact { get; set; }
        public List<Product> products { get; set; }

    }
}
