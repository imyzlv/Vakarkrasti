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
        public DateTime ArrivalDateTime { get; set; }

        [Required]
        public DateTime DepartureDateTime { get; set; }

        [Required]
        [Display(Name = "Viesu māja")]
        public string GuestHouse { get; set; }

        [Required]
        [Display(Name = "Viesu skaits")]
        public int NumberOfGuests { get; set; }

        [NotMapped]
        [Display(Name = "Ierašanās datums")]
        public string ArrivalDate => ArrivalDateTime.ToString("MM.dd.yyyy");

        [NotMapped]
        [Display(Name = "Ierašanās laiks")]
        public string ArrivalTime => ArrivalDateTime.ToString("HH:mm");

        [NotMapped]
        [Display(Name = "Izrakstīšanās datums")]
        public string DepartureDate => DepartureDateTime.ToString("MM.dd.yyyy");
        [NotMapped]
        [Display(Name = "Izrakstīšanās laiks")]
        public string DepartureTime => DepartureDateTime.ToString("HH:mm");
    }
}

