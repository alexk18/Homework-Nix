using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Data_Layer.Entities
{
    class Review
    {
        [Required]
        [Key]
        public Guid ReviewId { get; set; }
        public int Rating { get; set; }
        [Required(ErrorMessage = "Нельзя оставить это поле пустым")]
        [StringLength(15)]
        public string Text { get; set; }

        public DateTime WritingDate
        {
            get
            {
                return WritingDate;
            }
            private set
            {
                WritingDate = DateTime.Now;
            }
        }
        public string Edit(string text)
        {
            Text = text;
            WritingDate = DateTime.Now;
            return Text;
           
        }
        [Required(ErrorMessage = "Нельзя оставить это поле пустым")]
        public Product product { get; set; }
    }
}
