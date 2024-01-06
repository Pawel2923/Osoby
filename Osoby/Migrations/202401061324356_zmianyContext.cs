namespace Osoby.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class zmianyContext : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Osobas", "Waga", c => c.Single(nullable: false));
            AlterColumn("dbo.Osobas", "BMI", c => c.Single(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Osobas", "BMI", c => c.Double(nullable: false));
            AlterColumn("dbo.Osobas", "Waga", c => c.Double(nullable: false));
        }
    }
}
