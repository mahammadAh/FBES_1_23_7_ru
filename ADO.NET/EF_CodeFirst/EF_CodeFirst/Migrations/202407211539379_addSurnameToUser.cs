﻿namespace EF_CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addSurnameToUser : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "Surname", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "Surname");
        }
    }
}
