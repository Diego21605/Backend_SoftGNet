using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Backend_SoftGNet.Models
{
    public class Role
    {
        [Key, Column(Order = 1), Required]
        public int Id { get; set; }

        [Column(Order = 2, TypeName = "varchar(100)"), Required]
        public string Name { get; set; }

        [Column(Order = 3, TypeName = "varchar(max)"), Required]
        public string Description { get; set; }
    }
}
