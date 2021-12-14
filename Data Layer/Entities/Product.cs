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
        [Key]
        public Guid ProductId
        {
            get
            {
                return ProductId;
            }
            set
            {
                ProductId = Guid.NewGuid();
            }
        }
        [Required(ErrorMessage = "Укажите имя товара")]
        [StringLength(15)]
        public string Name { get; set; }
        public string Description { get; set; }
        [Required(ErrorMessage = "Укажите цену товара")]
        public uint Cost { get; set; }
        [Required(ErrorMessage = "Укажите количество товара")]
        [Range(0, 9999)]
        public int Count { get; set; }

        public bool Aviable
        {
            get { return Aviable; }
            private set
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

        [Required]
        public Publisher Publisher { get; set; }

        public List<Review> Review { get; set; }
        [Required]
        public List<Genre> Genre { get; set; }
        [Required]
        public List<Image> Image { get; set; }

    }
}
