using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Examp_3.Models
{
    public class UserModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Ten duoc yeu cau")]
        [MinLength(6, ErrorMessage = "So luong ki tu phai lon hon 6")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Mat khau duoc yeu cau")]
        [DataType(DataType.Password)]
        [MinLength(5, ErrorMessage = "So luong ki tu phai lon hon 5")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Xac nhan mat khau duoc yeu cau")]
        [DataType(DataType.Password)]
        [MinLength(5, ErrorMessage = "So luong ki tu phai lon hon 5")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Email duoc yeu cau")]
        [EmailAddress(ErrorMessage = "Loi format email")]
        public string Email { get; set; }
    }
}