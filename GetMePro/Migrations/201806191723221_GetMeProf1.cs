namespace GetMePro.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class GetMeProf1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "CategoryServises", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "CategoryServises");
        }
    }
}
