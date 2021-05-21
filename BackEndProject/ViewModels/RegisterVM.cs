using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndProject.ViewModels
{
    public class RegisterVM
    {
        [Required,MaxLength(250)]
        public string Fullname { get; set; }
        [Required]
        public string Username { get; set; }
        [Required, MaxLength(250),DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required, MaxLength(250), DataType(DataType.Password)]
        public string Password { get; set; }
        [Required, MaxLength(250), DataType(DataType.Password),Compare(nameof(Password))]
        public string CheckPassword { get; set; }
    }
}
