namespace GetMePro.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class GetMeProfMigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "Block", c => c.String());
            AddColumn("dbo.AspNetUsers", "NameWork", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "NameWork");
            DropColumn("dbo.AspNetUsers", "Block");
        }
    }
}
