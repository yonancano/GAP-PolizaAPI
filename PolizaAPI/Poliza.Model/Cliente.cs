using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Poliza.Model
{
    [Table("Cliente")]
    public class Cliente
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdCliente { get; set; }

        [Required]
        [StringLength(60, MinimumLength = 4)]
        public string Nombre { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [NotMapped]
        [JsonIgnore]
        public ICollection<Poliza> MisPolizas { get; set; }
    }
}
