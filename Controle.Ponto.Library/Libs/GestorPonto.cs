using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controle.Ponto.Library.Modelo.Contexto;
using Controle.Ponto.Library.Modelo.Entidades;

namespace Controle.Ponto.Library.Libs
{
    public class GestorPonto
    {
        private List<DiaPonto> diasPonto;

        /// <summary>
        /// Dias de registro de ponto
        /// </summary>
        public List<DiaPonto> DiasPonto
        {
            get { return diasPonto; }
            set { diasPonto = value; }
        }

        private List<Registro> registrosPonto;

        /// <summary>
        /// Registros de ponto
        /// </summary>
        public List<Registro> RegistrosPonto
        {
            get { return registrosPonto; }
            set { registrosPonto = value; }
        }

        private Usuario usuarioPonto;

        /// <summary>
        /// Usuario do ponto
        /// </summary>
        public Usuario UsuarioPonto
        {
            get { return usuarioPonto; }
            set { usuarioPonto = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dias"></param>
        /// <param name="registros"></param>
        /// <param name="usuario"></param>
        public GestorPonto(List<DiaPonto> dias, List<Registro> registros, Usuario usuario)
        {
            if(dias == null || registros == null || usuario == null)
                throw new ArgumentNullException( "Devem ser preenchidos todos os argumentos para o gestor de ponto." );

            diasPonto = dias;
            registrosPonto = registros;
            usuarioPonto = usuario;
        }

        public List<Registro> ListarRegistrosDataSelecionada(DateTime data)
        {
            return null;
        }

        public DiaPonto SelecionarDiaPontoPorData(DateTime data)
        {
            return null;
        }

        public TimeSpan CalcularHorasTrabalhadas() 
        {
            return TimeSpan.Zero;
        }
    }
}
