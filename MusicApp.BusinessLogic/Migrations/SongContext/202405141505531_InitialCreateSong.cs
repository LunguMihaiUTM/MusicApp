namespace MusicApp.BusinessLogic.Migrations.SongContext
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreateSong : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SongTables",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 50),
                        Artist = c.String(nullable: false, maxLength: 50),
                        Mp3File = c.Binary(nullable: false),
                        Mp3FileName = c.String(nullable: false, maxLength: 100),
                        Image = c.Binary(nullable: false),
                        ImageFileName = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.SongTables");
        }
    }
}
