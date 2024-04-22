namespace MusicApp.BusinessLogic.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUser : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO UDBTables (Username, Password, Email, level, LastLogin) VALUES('admin', 'admin', 'randomemail@gmail.com', '1', '2024-03-27')");
        }

        public override void Down()
        {
            Sql("DELETE FROM UDBTables WHERE Username = 'admin'");
        }
    }
}
