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
        [Key]
        public Guid UserId { get 
            {
                return UserId;
            } 
            set 
            {
                UserId = Guid.NewGuid();
            } 
        }
        [Required(ErrorMessage = "Логин пользователя не указан")]
        [StringLength(15,MinimumLength = 3, ErrorMessage = "Указан слишком большой логин")]
        public string Login { get; set; }
        [Required(ErrorMessage = "Пароль пользователя не указан")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Указан слишком большой пароль")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Не указан повторный пароль")]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }
        public string Adress { get; set; }
        [EmailAddress(ErrorMessage = "Неправильно указан адрес электронной почты")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Не указан мобильный телефон")]
        [Phone]
        [StringLength(10)]
        public string MobilePhone { get; set; }

        public void About()
        {
            Console.WriteLine(Login, Password, Adress, Email, MobilePhone); 
        }
        public Trashbox trashbox { get; set; }
    }
}
