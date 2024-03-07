using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Backend_SoftGNet.Models
{
    public class Users
    {
#pragma warning disable CS8618 // Un campo que no acepta valores NULL debe contener un valor distinto de NULL al salir del constructor. Considere la posibilidad de declararlo como que admite un valor NULL.
        [Key, Column(Order = 1)]
        public int Id { get; set; }

        [Column(Order = 2, TypeName = "varchar(200)"), Required]
        public string User_Name { get; set; }

        [Column(Order = 3, TypeName = "varchar(200)")]
        public string? User_Email { get; set;}

        [Column(Order = 4, TypeName = "varchar(max)"), Required]
        public string User_Password { get; set;  }

        [Column(Order = 5), Required]
        public int Role_Id { get; set; }
        public Role? Role { get; set; }

        [Column(Order = 6), Required]
        public bool Active { get; set; }
#pragma warning restore CS8618 // Un campo que no acepta valores NULL debe contener un valor distinto de NULL al salir del constructor. Considere la posibilidad de declararlo como que admite un valor NULL.
    }
}
