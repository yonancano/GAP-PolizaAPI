using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.Text.Json.Serialization;

namespace Poliza.Model
{
    [Table("Poliza")]
    public class Poliza
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdPoliza { get; set; }

        [Required]
        [StringLength(60, MinimumLength = 8)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(200, MinimumLength = 15)]
        public string Descripcion { get; set; }

        [Required]
        public byte TipoCubrimiento { get; set; }

        [Required]
        public byte PorcentajeCobertura { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime InicioVigencia { get; set; }

        [Required]
        public byte PeriodoCobertura { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        public decimal Precio { get; set; }

        [Required]
        public byte TipoRiesgo { get; set; }


        [ForeignKey(nameof(Cliente))]
        public int IdCliente { get; set; }

        [JsonIgnore]
        public Cliente Cliente { get; set; }
    }
}
