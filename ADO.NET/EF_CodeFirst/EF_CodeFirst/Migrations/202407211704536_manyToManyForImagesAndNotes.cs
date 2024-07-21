namespace EF_CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class manyToManyForImagesAndNotes : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.NotesImages",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NoteId = c.Int(nullable: false),
                        ImageId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Images", t => t.ImageId, cascadeDelete: true)
                .ForeignKey("dbo.Notes", t => t.NoteId, cascadeDelete: true)
                .Index(t => t.NoteId)
                .Index(t => t.ImageId);
            
            CreateTable(
                "dbo.ImageNotes",
                c => new
                    {
                        Image_Id = c.Int(nullable: false),
                        Note_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Image_Id, t.Note_Id })
                .ForeignKey("dbo.Images", t => t.Image_Id, cascadeDelete: true)
                .ForeignKey("dbo.Notes", t => t.Note_Id, cascadeDelete: true)
                .Index(t => t.Image_Id)
                .Index(t => t.Note_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.NotesImages", "NoteId", "dbo.Notes");
            DropForeignKey("dbo.NotesImages", "ImageId", "dbo.Images");
            DropForeignKey("dbo.ImageNotes", "Note_Id", "dbo.Notes");
            DropForeignKey("dbo.ImageNotes", "Image_Id", "dbo.Images");
            DropIndex("dbo.ImageNotes", new[] { "Note_Id" });
            DropIndex("dbo.ImageNotes", new[] { "Image_Id" });
            DropIndex("dbo.NotesImages", new[] { "ImageId" });
            DropIndex("dbo.NotesImages", new[] { "NoteId" });
            DropTable("dbo.ImageNotes");
            DropTable("dbo.NotesImages");
        }
    }
}
