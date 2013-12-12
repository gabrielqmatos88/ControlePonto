using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controle.Ponto.Library.Modelo.Entidades;

namespace Controle.Ponto.Library.Modelo.Contexto
{
    public class PontoContext :DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<DiaPonto> DiasPonto { get; set; }

        public DbSet<Registro> Registros { get; set; }

        public PontoContext()
            :base("name=pontoConnection")
        {
        }
    }
}
