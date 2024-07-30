namespace EF_CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangePrimaryKey : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.IdCards", "Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.IdCards", "Id", c => c.Int(nullable: false));
        }
    }
}
