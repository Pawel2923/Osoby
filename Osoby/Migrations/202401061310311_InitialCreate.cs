namespace Osoby.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Osobas",
                c => new
                    {
                        OsobaId = c.Int(nullable: false, identity: true),
                        Imie = c.String(nullable: false),
                        Nazwisko = c.String(nullable: false),
                        Wiek = c.Int(nullable: false),
                        Waga = c.Double(nullable: false),
                        BMI = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.OsobaId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Osobas");
        }
    }
}
