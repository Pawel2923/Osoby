namespace Osoby.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class zmianyContext3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Osobas", "WskaznikBMI", c => c.String());
            AlterColumn("dbo.Osobas", "BMI", c => c.Double());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Osobas", "BMI", c => c.Double(nullable: false));
            DropColumn("dbo.Osobas", "WskaznikBMI");
        }
    }
}
