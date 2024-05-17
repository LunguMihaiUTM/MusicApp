namespace MusicApp.BusinessLogic.Migrations.SongContext
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class SongConfiguration : DbMigrationsConfiguration<MusicApp.BusinessLogic.DBModel.SongContext>
    {
        public SongConfiguration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"Migrations/SongContext";
        }

        protected override void Seed(MusicApp.BusinessLogic.DBModel.SongContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
