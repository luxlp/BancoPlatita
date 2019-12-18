namespace TPFinal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigracionBanco1712 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Operacions",
                c => new
                    {
                        OperacionId = c.Int(nullable: false, identity: true),
                        TipoOperacion = c.String(),
                        TiempoInsumido = c.String(),
                        Usuario_UsuarioId = c.Int(),
                    })
                .PrimaryKey(t => t.OperacionId)
                .ForeignKey("dbo.Usuarios", t => t.Usuario_UsuarioId)
                .Index(t => t.Usuario_UsuarioId);
            
            CreateTable(
                "dbo.Usuarios",
                c => new
                    {
                        UsuarioId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Categoria = c.String(),
                    })
                .PrimaryKey(t => t.UsuarioId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Operacions", "Usuario_UsuarioId", "dbo.Usuarios");
            DropIndex("dbo.Operacions", new[] { "Usuario_UsuarioId" });
            DropTable("dbo.Usuarios");
            DropTable("dbo.Operacions");
        }
    }
}
