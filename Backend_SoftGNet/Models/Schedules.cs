using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Backend_SoftGNet.Models
{
    public class Schedules
    {
#pragma warning disable CS8618 // Un campo que no acepta valores NULL debe contener un valor distinto de NULL al salir del constructor. Considere la posibilidad de declararlo como que admite un valor NULL.

        [Key, Column(Order = 1)]
        public int Id { get; set; }

        [Column(Order = 2), Required]
        public int Route_Id { get; set; }
        public Routes Route { get; set; }

        [Column(Order = 3), Required]
        public int Week_Num { get; set; }

        [Column(Order = 4, TypeName = "datetime"), Required]
        public DateTime From { get; set; }

        [Column(Order = 5, TypeName = "datetime"), Required]
        public DateTime To { get; set; }

        [Column(Order = 6), Required]
        public bool Active { get; set; }

#pragma warning restore CS8618 // Un campo que no acepta valores NULL debe contener un valor distinto de NULL al salir del constructor. Considere la posibilidad de declararlo como que admite un valor NULL.
    }
}
