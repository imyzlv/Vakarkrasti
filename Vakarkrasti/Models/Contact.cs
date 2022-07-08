using System;
using System.ComponentModel.DataAnnotations;

namespace Vakarkrasti.Models
{
	public class Contact
	{
        [Key]
		public int Id { get; set; }

        [Required]
        [Display(Name = "Vārds")]
		public string? Name { get; set; }

        [Required]
        [Display(Name ="Ziņojums")]
		public string? Message { get; set; }

        [Required]
        [Phone]
        [Display(Name ="Telefona Nr.")]
		public string? Phone { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name ="E-pasts")]
        public string? Email { get; set; }

	}
}

