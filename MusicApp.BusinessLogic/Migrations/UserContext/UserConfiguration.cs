using System.Data.Entity.Migrations;

namespace MusicApp.BusinessLogic.Migrations.UserContext
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class UserConfiguration : DbMigrationsConfiguration<MusicApp.BusinessLogic.DBModel.UserContext>
    {
        public UserConfiguration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"Migrations/UserContext";
        }

        protected override void Seed(MusicApp.BusinessLogic.DBModel.UserContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
