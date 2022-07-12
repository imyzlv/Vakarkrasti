using System;
using System.ComponentModel.DataAnnotations;

namespace Vakarkrasti.Models
{
    public class Houses
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Nosaukums")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Guļvietu skaits")]
        public int BedCount { get; set; }
        [Required]
        [Display(Name = "Cena par nakti")]
        public decimal Price { get; set; }
    }
}

