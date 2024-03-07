using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Backend_SoftGNet.Models
{
    public class Routes
    {
#pragma warning disable CS8618 // Un campo que no acepta valores NULL debe contener un valor distinto de NULL al salir del constructor. Considere la posibilidad de declararlo como que admite un valor NULL.

        [Key, Column(Order = 1)]
        public int Id { get; set; }

        [Column(Order = 2, TypeName = "varchar(max)"), Required]
        public string Description { get; set; }

        [Column(Order = 3), Required]
        public int Driver_Id { get; set; }
        public Drivers? Drivers { get; set; }

        [Column(Order = 4), Required]
        public int Vehicle_Id { get; set; }
        public Vehicles? Vehicles { get; set; }

        [Column(Order = 5), Required]
        public bool Active { get; set; }

#pragma warning restore CS8618 // Un campo que no acepta valores NULL debe contener un valor distinto de NULL al salir del constructor. Considere la posibilidad de declararlo como que admite un valor NULL.
    }
}
