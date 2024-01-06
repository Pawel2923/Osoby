namespace Osoby.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class zmianyContext4 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Osobas", "Wzrost", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Osobas", "Wzrost");
        }
    }
}
