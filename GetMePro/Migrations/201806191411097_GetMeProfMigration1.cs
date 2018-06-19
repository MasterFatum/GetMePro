namespace GetMePro.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class GetMeProfMigration1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.AspNetUsers", "Block", c => c.String(nullable: false));
            AlterColumn("dbo.AspNetUsers", "NameWork", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.AspNetUsers", "NameWork", c => c.String());
            AlterColumn("dbo.AspNetUsers", "Block", c => c.String());
        }
    }
}
