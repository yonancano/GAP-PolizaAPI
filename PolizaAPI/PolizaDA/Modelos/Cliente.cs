using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PolizaDA.Modelos
{
    public class Cliente
    {            
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdCliente { get; set; }

        public string Nombre { get; set; }

        public string Email { get; set; }

        public ICollection<Poliza> MisPolizas { get; set; }
    }
}