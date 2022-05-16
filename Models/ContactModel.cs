using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Assignment_5.Models
{
    public class ContactModel
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="Please make sure to enter your name")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Use letters only please")]
        public string? Name { get; set; }
        [Required(ErrorMessage = "Please make sure to enter your email address")]
        [DataType(DataType.EmailAddress)]
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", ErrorMessage = "Please make sure that your email address is valid.")]
        public string? Email { get; set; }
        [Required(ErrorMessage ="Please don't leave the messagebox empty")]
        public string? Message{ get; set;}
    }
}
