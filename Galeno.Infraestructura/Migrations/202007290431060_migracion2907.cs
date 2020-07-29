namespace Galeno.Infraestructura.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migracion2907 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DiaHorarios",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        IdDia = c.Long(nullable: false),
                        IdHorarioPrestador = c.Long(nullable: false),
                        EstaEliminado = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Dias", t => t.IdDia)
                .ForeignKey("dbo.HorarioPrestadores", t => t.IdHorarioPrestador)
                .Index(t => t.IdDia)
                .Index(t => t.IdHorarioPrestador);
            
            CreateTable(
                "dbo.Dias",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Descripcion = c.String(nullable: false, maxLength: 100, storeType: "nvarchar"),
                        EstaEliminado = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.HorarioPrestadores",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        IdPrestadorEstablecimiento = c.Long(nullable: false),
                        HoraInicio = c.Time(nullable: false, precision: 0),
                        HoraFin = c.Time(nullable: false, precision: 0),
                        EstaEliminado = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.PrestadorEstablecimientos", t => t.IdPrestadorEstablecimiento)
                .Index(t => t.IdPrestadorEstablecimiento);
            
            CreateTable(
                "dbo.PrestadorEstablecimientos",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        IdPrestadorEspecialidad = c.Long(nullable: false),
                        IdEstablecimiento = c.Long(nullable: false),
                        EstaEliminado = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Establecimientos", t => t.IdEstablecimiento)
                .ForeignKey("dbo.PrestadorEspecialidades", t => t.IdPrestadorEspecialidad)
                .Index(t => t.IdPrestadorEspecialidad)
                .Index(t => t.IdEstablecimiento);
            
            CreateTable(
                "dbo.Establecimientos",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        RazonSocial = c.String(nullable: false, maxLength: 150, storeType: "nvarchar"),
                        Direccion = c.String(nullable: false, maxLength: 200, storeType: "nvarchar"),
                        IdLocalidad = c.Long(nullable: false),
                        EstaEliminado = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Localidades", t => t.IdLocalidad)
                .Index(t => t.IdLocalidad);
            
            CreateTable(
                "dbo.Localidades",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Descripcion = c.String(nullable: false, maxLength: 250, storeType: "nvarchar"),
                        EstaEliminado = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PrestadorEspecialidades",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        IdPrestador = c.Long(nullable: false),
                        IdEspecialidad = c.Long(nullable: false),
                        EstaEliminado = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Especialidades", t => t.IdEspecialidad)
                .ForeignKey("dbo.Prestadores", t => t.IdPrestador)
                .Index(t => t.IdPrestador)
                .Index(t => t.IdEspecialidad);
            
            CreateTable(
                "dbo.Especialidades",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Descripcion = c.String(nullable: false, maxLength: 100, storeType: "nvarchar"),
                        EstaEliminado = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Prestadores",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 250, storeType: "nvarchar"),
                        Apellido = c.String(nullable: false, maxLength: 250, storeType: "nvarchar"),
                        EstaEliminado = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DiaHorarios", "IdHorarioPrestador", "dbo.HorarioPrestadores");
            DropForeignKey("dbo.HorarioPrestadores", "IdPrestadorEstablecimiento", "dbo.PrestadorEstablecimientos");
            DropForeignKey("dbo.PrestadorEstablecimientos", "IdPrestadorEspecialidad", "dbo.PrestadorEspecialidades");
            DropForeignKey("dbo.PrestadorEspecialidades", "IdPrestador", "dbo.Prestadores");
            DropForeignKey("dbo.PrestadorEspecialidades", "IdEspecialidad", "dbo.Especialidades");
            DropForeignKey("dbo.PrestadorEstablecimientos", "IdEstablecimiento", "dbo.Establecimientos");
            DropForeignKey("dbo.Establecimientos", "IdLocalidad", "dbo.Localidades");
            DropForeignKey("dbo.DiaHorarios", "IdDia", "dbo.Dias");
            DropIndex("dbo.PrestadorEspecialidades", new[] { "IdEspecialidad" });
            DropIndex("dbo.PrestadorEspecialidades", new[] { "IdPrestador" });
            DropIndex("dbo.Establecimientos", new[] { "IdLocalidad" });
            DropIndex("dbo.PrestadorEstablecimientos", new[] { "IdEstablecimiento" });
            DropIndex("dbo.PrestadorEstablecimientos", new[] { "IdPrestadorEspecialidad" });
            DropIndex("dbo.HorarioPrestadores", new[] { "IdPrestadorEstablecimiento" });
            DropIndex("dbo.DiaHorarios", new[] { "IdHorarioPrestador" });
            DropIndex("dbo.DiaHorarios", new[] { "IdDia" });
            DropTable("dbo.Prestadores");
            DropTable("dbo.Especialidades");
            DropTable("dbo.PrestadorEspecialidades");
            DropTable("dbo.Localidades");
            DropTable("dbo.Establecimientos");
            DropTable("dbo.PrestadorEstablecimientos");
            DropTable("dbo.HorarioPrestadores");
            DropTable("dbo.Dias");
            DropTable("dbo.DiaHorarios");
        }
    }
}
