using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vakarkrasti.Models
{
    public class Reservations
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name="Vārds, Uzvārds")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "E-pasts")]
        public string Email { get; set; }

        [Required]
        [Display(Name ="Ierašanās datums")]
        public DateTime ArrivalDateTime { get; set; }

        [Required]
        [Display(Name ="Izrakstīšanās datums")]
        public DateTime DepartureDateTime { get; set; }

        [Required]
        [Display(Name = "Viesu māja")]
        public string GuestHouse { get; set; }

        [Required]
        [Display(Name = "Viesu skaits")]
        public int NumberOfGuests { get; set; }
        [Display(Name="Papildu komentārs:")]
        public string? Comment { get; set; }
    }
}

