using Controle.Ponto.Library.Modelo.Contexto;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle.Ponto.Library.Modelo.Entidades.DAO
{
    public static class UsuarioDao
    {
        /// <summary>
        /// Consultar um usuário por Id
        /// </summary>
        /// <param name="contexto">contexto do banco</param>
        /// <param name="id">id do usuario</param>
        /// <returns></returns>
        public static Usuario ConsultarUsuario(PontoContext contexto, int id) 
        {
            return contexto.Usuarios.Find(id);
        }

        /// <summary>
        /// Consultar um usuário por matricula
        /// </summary>
        /// <param name="contexto">contexto do banco</param>
        /// <param name="matricula">matricula do usuario</param>
        /// <returns></returns>
        public static Usuario ConsultarUsuarioPorMatricula(PontoContext contexto, int matricula) 
        {
            return contexto.Usuarios.SingleOrDefault(o=>o.Matricula.Equals(matricula));
        }

        /// <summary>
        /// Salvar um usuario no contexto
        /// </summary>
        /// <param name="contexto"></param>
        /// <param name="usuario"></param>
        /// <returns></returns>
        public static bool SalvarUsuario(PontoContext contexto, Usuario usuario) 
        {
            Usuario usuarioCadastrado = ConsultarUsuario(contexto,usuario.Id);
            if (usuarioCadastrado != null) 
                contexto.Entry(usuario).State = EntityState.Modified;
            else
                contexto.Usuarios.Add(usuarioCadastrado);
            return contexto.SaveChanges() == 1;
        }

        /// <summary>
        /// Excluir um usuario (Exclusão lógica)
        /// </summary>
        /// <param name="contexto">contexto do banco</param>
        /// <param name="usuario">usuario</param>
        public static void ExcluirUsuario(PontoContext contexto, Usuario usuario) 
        {
            ExcluirUsuario(contexto, usuario.Id);
        }

        /// <summary>
        /// Excluir um usuario (Exclusão lógica)
        /// </summary>
        /// <param name="contexto">contexto do banco</param>
        /// <param name="id">id do usuario</param>
        public static void ExcluirUsuario(PontoContext contexto,int id) 
        {
            Usuario usuario = ConsultarUsuario(contexto, id);

            if (usuario == null || usuario.CsExcluido)
                return;

            usuario.CsExcluido = true;
            contexto.SaveChanges();
        }
    }
}
