using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle.Ponto.Library.Entidades
{
    [Table("DiaPonto")]
    public class DiaPonto : Entidade
    {
        [ForeignKey("Usuario")]
        public int IdUsuario { get; set; }

        public Usuario Usuario { get; set; }

        public DateTime Data { get; set; }

        public List<Registro> Registros { get; set; }
    }
}
