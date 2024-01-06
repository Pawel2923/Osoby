namespace Osoby.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class zmianyContext1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Osobas", "Waga", c => c.Int(nullable: false));
            AlterColumn("dbo.Osobas", "BMI", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Osobas", "BMI", c => c.Single(nullable: false));
            AlterColumn("dbo.Osobas", "Waga", c => c.Single(nullable: false));
        }
    }
}
