namespace Osoby.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class zmianyContext2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Osobas", "Waga", c => c.Double(nullable: false));
            AlterColumn("dbo.Osobas", "BMI", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Osobas", "BMI", c => c.Int(nullable: false));
            AlterColumn("dbo.Osobas", "Waga", c => c.Int(nullable: false));
        }
    }
}
