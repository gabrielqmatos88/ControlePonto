namespace Controle.Ponto.Library.Modelo.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Controle.Ponto.Library.Modelo.Entidades;

    internal sealed class Configuration : DbMigrationsConfiguration<Controle.Ponto.Library.Modelo.Contexto.PontoContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Controle.Ponto.Library.Modelo.Contexto.PontoContext context)
        {

            Usuario userTest = new Usuario() { Id = 1 , Nome = "gabriel.matos" , Matricula = 688 , Senha = "123456" };
            DiaPonto dia = new DiaPonto() { Id = 1, Registros = new List<Registro>(), Data = DateTime.Now.Date, Usuario = userTest };
            dia.Registros.Add(new Registro() { Hora = new TimeSpan(8,0,0) });
            dia.Registros.Add(new Registro() { Hora = new TimeSpan(12, 0, 0) });
            dia.Registros.Add(new Registro() { Hora = new TimeSpan(13, 0, 0) });
            dia.Registros.Add(new Registro() { Hora = new TimeSpan(18, 0, 0) });
            context.DiasPonto.Add(dia);
            context.SaveChanges();

            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
