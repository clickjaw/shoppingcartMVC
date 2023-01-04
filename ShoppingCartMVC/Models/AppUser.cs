using System;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ShoppingCartMVC.Models
{
	public class AppUser: IdentityUser
	{
		public string Occupation { get; set; }

        //public string Email { get; set; }

        public string RoleId { get; set; }

        public string Role { get; set; }
        
        //public IEnumerable<SelectListItem> RoleList { get; set; }
    }
}

