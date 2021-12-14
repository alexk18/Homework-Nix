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
        private int Rating { get; set; }
        [Required]
        [StringLength(15)]
        private string Text { get; set; }

        private DateTime WritingDate
        {
            get
            {
                return WritingDate;
            }
            set
            {
                WritingDate = DateTime.Now;
            }
        }
    }
}
