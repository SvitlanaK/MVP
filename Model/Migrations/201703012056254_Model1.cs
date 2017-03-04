namespace Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Model1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.AuthorMagazines", "AuthorId", "dbo.Authors");
            DropForeignKey("dbo.AuthorMagazines", "MagazineId", "dbo.Magazines");
            DropIndex("dbo.AuthorMagazines", new[] { "MagazineId" });
            DropIndex("dbo.AuthorMagazines", new[] { "AuthorId" });
            RenameColumn(table: "dbo.AuthorMagazines", name: "AuthorId", newName: "Author_Id");
            RenameColumn(table: "dbo.AuthorMagazines", name: "MagazineId", newName: "Magazine_Id");
            AlterColumn("dbo.AuthorMagazines", "Magazine_Id", c => c.Int());
            AlterColumn("dbo.AuthorMagazines", "Author_Id", c => c.Int());
            CreateIndex("dbo.AuthorMagazines", "Author_Id");
            CreateIndex("dbo.AuthorMagazines", "Magazine_Id");
            AddForeignKey("dbo.AuthorMagazines", "Author_Id", "dbo.Authors", "Id");
            AddForeignKey("dbo.AuthorMagazines", "Magazine_Id", "dbo.Magazines", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AuthorMagazines", "Magazine_Id", "dbo.Magazines");
            DropForeignKey("dbo.AuthorMagazines", "Author_Id", "dbo.Authors");
            DropIndex("dbo.AuthorMagazines", new[] { "Magazine_Id" });
            DropIndex("dbo.AuthorMagazines", new[] { "Author_Id" });
            AlterColumn("dbo.AuthorMagazines", "Author_Id", c => c.Int(nullable: false));
            AlterColumn("dbo.AuthorMagazines", "Magazine_Id", c => c.Int(nullable: false));
            RenameColumn(table: "dbo.AuthorMagazines", name: "Magazine_Id", newName: "MagazineId");
            RenameColumn(table: "dbo.AuthorMagazines", name: "Author_Id", newName: "AuthorId");
            CreateIndex("dbo.AuthorMagazines", "AuthorId");
            CreateIndex("dbo.AuthorMagazines", "MagazineId");
            AddForeignKey("dbo.AuthorMagazines", "MagazineId", "dbo.Magazines", "Id", cascadeDelete: true);
            AddForeignKey("dbo.AuthorMagazines", "AuthorId", "dbo.Authors", "Id", cascadeDelete: true);
        }
    }
}
