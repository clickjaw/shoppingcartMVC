using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace ShoppingCartMVC.Models
{
	public class User
	{
       
            public string Id { get; set; }

            [Required, MinLength(2, ErrorMessage = "Minimum length is 2")]
            [Display(Name = "Username")]
            public string UserName { get; set; }
            [Required, EmailAddress]
            public string Email { get; set; }
            [DataType(DataType.Password), Required, MinLength(4, ErrorMessage = "Minimum length is 4")]
            public string Password { get; set; }

            [DataType(DataType.Password)]
            [Display(Name = "Confirm Password")]
            [Compare("Password", ErrorMessage = "The password and confirmation password are not the same.")]
            public string ConfirmPassword { get; set; }
    }
    }


