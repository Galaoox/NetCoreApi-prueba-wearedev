
using System.ComponentModel.DataAnnotations;

namespace NetCoreApi.Data.Models
{
    public partial class Cliente
    {
        public Cliente()
        {
        }
        [Key]
        public int Id { get; set; }
        [MaxLength(15)]
        [Required]
        public string Cedula { get; set; }
        [MaxLength(100)]
        [Required]
        public string Nombre { get; set; }
        [MaxLength(100)]
        [Required]
        public string Apellido { get; set; }
        [MaxLength(15)]
        [Required]
        public string Telefono { get; set; }
        [Required]
        public short Disabled { get; set; }

    }
}
