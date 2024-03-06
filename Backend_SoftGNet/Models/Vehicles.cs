using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Backend_SoftGNet.Models
{
    public class Vehicles
    {
#pragma warning disable CS8618 // Un campo que no acepta valores NULL debe contener un valor distinto de NULL al salir del constructor. Considere la posibilidad de declararlo como que admite un valor NULL.
        [Key, Column(Order = 1 ), Required] 
        public int Id { get; set; }

        [Column(Order = 2, TypeName = "varchar(200)"), Required]
        public string Descripcion { get; set; }

        [Column(Order = 3), Required]
        public int Year { get; set; }

        [Column(Order = 4), Required]
        public int Make { get; set; }

        [Column(Order = 5), Required]
        public int Capacity { get; set; }

        [Column(Order = 6), Required]
        public bool Active { get; set; }
#pragma warning restore CS8618 // Un campo que no acepta valores NULL debe contener un valor distinto de NULL al salir del constructor. Considere la posibilidad de declararlo como que admite un valor NULL.
    }
}
