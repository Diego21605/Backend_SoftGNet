using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Backend_SoftGNet.Models
{
    public class Drivers
    {
#pragma warning disable CS8618 // Un campo que no acepta valores NULL debe contener un valor distinto de NULL al salir del constructor. Considere la posibilidad de declararlo como que admite un valor NULL.

        [Key, Column(Order = 1), Required]
        public int Id { get; set; }

        [Column(Order = 2, TypeName = "varchar(max)"), Required]
        public string Last_name { get; set; }

        [Column(Order = 3, TypeName = "varchar(200)"), Required]
        public string First_name { get; set; }

        [Column(Order = 4, TypeName = "varchar(50)"), Required]
        public string Ssn { get; set; }

        [Column(Order = 5, TypeName = "date"), Required]
        public DateTime Dob { get; set; }

        [Column(Order = 6, TypeName = "varchar(100)")]
        public string? Address { get; set; }

        [Column(Order = 7, TypeName = "varchar(100)")]
        public string? City { get; set; }

        [Column(Order = 8, TypeName = "varchar(100)")]
        public string? Zip { get; set; }

        [Column(Order = 9)]
        public int? Phone { get; set; }

        [Column(Order = 10), Required]
        public bool Active { get; set; }

#pragma warning restore CS8618 // Un campo que no acepta valores NULL debe contener un valor distinto de NULL al salir del constructor. Considere la posibilidad de declararlo como que admite un valor NULL.
    }
}
