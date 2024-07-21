namespace EF_CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addIdCard : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.IdCards",
                c => new
                    {
                        UserId = c.Int(nullable: false),
                        Id = c.Int(nullable: false),
                        FIN = c.String(),
                    })
                .PrimaryKey(t => t.UserId)
                .ForeignKey("dbo.Users", t => t.UserId)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.IdCards", "UserId", "dbo.Users");
            DropIndex("dbo.IdCards", new[] { "UserId" });
            DropTable("dbo.IdCards");
        }
    }
}
