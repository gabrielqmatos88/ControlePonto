using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle.Ponto.Library.Modelo.Entidades
{
    [Table("Registro")]
    public class Registro :Entidade
    {
        public TimeSpan Hora { get; set; }

        [ForeignKey("DiaPonto")]
        public int IdDiaPonto { get; set; }

        public DiaPonto DiaPonto { get; set; }
    }
}
