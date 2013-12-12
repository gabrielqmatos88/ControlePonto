using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle.Ponto.Library.Entidades
{
    [Table("Usuario")]
    public class Usuario : Entidade
    {
        [StringLength(100,ErrorMessage="O nome deve conter entre 5 e 100 caracteres")]
        public string Nome { get; set; }

        [StringLength(50)]
        public string Senha { get; set; }

        public int Matricula { get; set; }
    }
}
