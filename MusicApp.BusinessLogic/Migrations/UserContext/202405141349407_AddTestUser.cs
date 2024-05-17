namespace MusicApp.BusinessLogic.Migrations.UserContext
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTestUser : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO UDBTables (Username, Password, Email, LastLogin, LastIp, Level) 
                  VALUES ('user', 'user', 'user@example.com', 2023-05-14, '127.0.0.1', 1)");
        }
        
        public override void Down()
        {
            Sql(@"DELETE FROM UDBTables WHERE Username = 'user'");
        }
    }
}
