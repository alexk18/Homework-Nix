using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Data_Layer.Entities
{
    class Product
    {
        [Required]
        [StringLength(15)]
        private string Name { get; set; }
        private string Description { get; set; }
        [Required]
        [Range(0,9999)]
        private int Cost { get; set; }
        [Required]
        [Range(0, 9999)]
        private int Count { get; set; }

        private bool Aviable
        {
            get { return Aviable; }
            set
            {
                if (Count == 0)
                {
                    Aviable = false;
                }
                else
                {
                    Aviable = true;
                }
            }
        }
    

        private Review Review { get; set; }
        [Required]
        private Genre Genre { get; set; }
        [Required]
        private List<Image> Image { get; set; }

    }
}
