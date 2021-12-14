using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Data_Layer.Entities
{
    class User
    {
        [Required]
        [StringLength(15)]
        private string Login { get; set; }
        [Required]
        [StringLength(20)]
        private string Password { get; set; }
        [Required]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }
        private string Adress { get; set; }
        [EmailAddress]
        private string Email { get; set; }
        [Required]
        [Phone]
        [StringLength(10)]
        private string MobilePhone { get; set; }
    }
}
