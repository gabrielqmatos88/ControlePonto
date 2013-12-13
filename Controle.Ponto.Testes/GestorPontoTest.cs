using System;
using System.Collections.Generic;
using Controle.Ponto.Library.Libs;
using Controle.Ponto.Library.Modelo.Entidades;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Controle.Ponto.Testes
{
    [TestClass]
    public class GestorPontoTest
    {
        private GestorPonto gestor;

        private List<DiaPonto> dias;

        private List<Registro> registros;

        private List<Usuario> usuarios;

        [TestInitialize]
        public void Inicializador()
        {
            InicializarUsuarios();
            InicializarRegistros();
            InicializarDias();
        }

        public void InicializarDias()
        {
            dias = new List<DiaPonto>();
            dias.Add( new DiaPonto() { Id = 1, Data = new DateTime( 2013, 12, 7 ),  IdUsuario = 1 } );
            dias.Add( new DiaPonto() { Id = 2, Data = new DateTime( 2013, 12, 4 ),  IdUsuario = 2 } );
            dias.Add( new DiaPonto() { Id = 3, Data = new DateTime( 2013, 12, 2 ),  IdUsuario = 3 } );
            dias.Add( new DiaPonto() { Id = 4, Data = new DateTime( 2013, 12, 3 ),  IdUsuario = 3 } );
            dias.Add( new DiaPonto() { Id = 5, Data = new DateTime( 2013, 12, 6 ),  IdUsuario = 2 } );
            dias.Add( new DiaPonto() { Id = 6, Data = new DateTime( 2013, 12, 2 ),  IdUsuario = 1 } );
            dias.Add( new DiaPonto() { Id = 7, Data = new DateTime( 2013, 12, 6 ),  IdUsuario = 1 } );
            dias.Add( new DiaPonto() { Id = 8, Data = new DateTime( 2013, 12, 5 ),  IdUsuario = 1 } );
            dias.Add( new DiaPonto() { Id = 9, Data = new DateTime( 2013, 12, 3 ),  IdUsuario = 2 } );
            dias.Add( new DiaPonto() { Id = 10, Data = new DateTime( 2013, 12, 2 ), IdUsuario = 3 } );
            dias.Add( new DiaPonto() { Id = 11, Data = new DateTime( 2013, 12, 7 ), IdUsuario = 2 } );
            dias.Add( new DiaPonto() { Id = 12, Data = new DateTime( 2013, 12, 7 ), IdUsuario = 3 } );
        }

        public void InicializarUsuarios()
        {
            usuarios = new List<Usuario>();
            usuarios.Add( new Usuario() { Id = 1, Matricula = 001, Nome = "Joao Neto" , Senha = "123" } );
            usuarios.Add( new Usuario() { Id = 3, Matricula = 002, Nome = "Marcio Nery", Senha = "123" } );
            usuarios.Add( new Usuario() { Id = 2, Matricula = 003, Nome = "Reinaldo Thompson", Senha = "123" } );
        }

        public void InicializarRegistros()
        {
            registros = new List<Registro>();
            registros.Add( new Registro() { Id = 1, IdDiaPonto = 1, Hora = new TimeSpan( 8, 0, 0 ) } );
            registros.Add( new Registro() { Id = 2, IdDiaPonto = 1, Hora = new TimeSpan( 12, 0, 0 ) } );
            registros.Add( new Registro() { Id = 3, IdDiaPonto = 1, Hora = new TimeSpan( 13, 0, 0 ) } );
            registros.Add( new Registro() { Id = 4, IdDiaPonto = 1, Hora = new TimeSpan( 17, 0, 0 ) } );
            registros.Add( new Registro() { Id = 5, IdDiaPonto = 1, Hora = new TimeSpan( 9, 40, 0 ) } );
            registros.Add( new Registro() { Id = 6, IdDiaPonto = 1, Hora = new TimeSpan( 12, 0, 0 ) } );
            registros.Add( new Registro() { Id = 7, IdDiaPonto = 1, Hora = new TimeSpan( 17, 0, 0 ) } );
            registros.Add( new Registro() { Id = 8, IdDiaPonto = 1, Hora = new TimeSpan( 8, 0, 0 ) } );
            registros.Add( new Registro() { Id = 9, IdDiaPonto = 1, Hora = new TimeSpan( 8, 0, 0 ) } );
            registros.Add( new Registro() { Id = 10, IdDiaPonto = 1, Hora = new TimeSpan( 8, 0, 0 ) } );
            registros.Add( new Registro() { Id = 11, IdDiaPonto = 1, Hora = new TimeSpan( 8, 0, 0 ) } );
            registros.Add( new Registro() { Id = 12, IdDiaPonto = 1, Hora = new TimeSpan( 8, 0, 0 ) } );
            registros.Add( new Registro() { Id = 13, IdDiaPonto = 1, Hora = new TimeSpan( 8, 0, 0 ) } );
            registros.Add( new Registro() { Id = 14, IdDiaPonto = 1, Hora = new TimeSpan( 8, 0, 0 ) } );
            registros.Add( new Registro() { Id = 15, IdDiaPonto = 1, Hora = new TimeSpan( 8, 0, 0 ) } );
            registros.Add( new Registro() { Id = 16, IdDiaPonto = 1, Hora = new TimeSpan( 8, 0, 0 ) } );
            registros.Add( new Registro() { Id = 17, IdDiaPonto = 1, Hora = new TimeSpan( 8, 0, 0 ) } );
            registros.Add( new Registro() { Id = 18, IdDiaPonto = 1, Hora = new TimeSpan( 8, 0, 0 ) } );
            registros.Add( new Registro() { Id = 19, IdDiaPonto = 1, Hora = new TimeSpan( 8, 0, 0 ) } );
            registros.Add( new Registro() { Id = 20, IdDiaPonto = 1, Hora = new TimeSpan( 8, 0, 0 ) } );
            registros.Add( new Registro() { Id = 21, IdDiaPonto = 1, Hora = new TimeSpan( 8, 0, 0 ) } );
            registros.Add( new Registro() { Id = 22, IdDiaPonto = 1, Hora = new TimeSpan( 8, 0, 0 ) } );
            registros.Add( new Registro() { Id = 23, IdDiaPonto = 1, Hora = new TimeSpan( 8, 0, 0 ) } );
            registros.Add( new Registro() { Id = 24, IdDiaPonto = 1, Hora = new TimeSpan( 8, 0, 0 ) } );
            registros.Add( new Registro() { Id = 25, IdDiaPonto = 1, Hora = new TimeSpan( 8, 0, 0 ) } );
            registros.Add( new Registro() { Id = 26, IdDiaPonto = 1, Hora = new TimeSpan( 8, 0, 0 ) } );
            registros.Add( new Registro() { Id = 27, IdDiaPonto = 1, Hora = new TimeSpan( 8, 0, 0 ) } );
            registros.Add( new Registro() { Id = 28, IdDiaPonto = 1, Hora = new TimeSpan( 8, 0, 0 ) } );
            registros.Add( new Registro() { Id = 29, IdDiaPonto = 1, Hora = new TimeSpan( 8, 0, 0 ) } );
        }

        [TestMethod]
        public void DeveSelecionarODiaDePontoParaADataSelecionada()
        {

        }

        [TestMethod]
        public void DeveSelecionarOsRegistrosParaADataSelecionada()
        {

        }

    }
}
