using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PolizaDA.Modelos
{
    public class Poliza
    {            
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdPoliza { get; set; }

        public string Nombre { get; set; }

        public string Descripcion { get; set; }

        public byte TipoCubrimiento { get; set; }

        public byte PorcentajeCobertura { get; set; }

        public DateTime InicioVigencia => DateTime.Now;

        public byte PeriodoCobertura { get; set; }

        public decimal Precio { get; set; }

        public byte TipoRiesgo { get; set; }


        [ForeignKey(nameof(Cliente))]
        public int IdCliente { get; set; }
        public Cliente Cliente { get; set; }
    }
}