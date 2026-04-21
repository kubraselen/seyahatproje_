namespace seyahatproje.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<seyahatproje.Models.siniflar.Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled =true;
        }

        protected override void Seed(seyahatproje.Models.siniflar.Context context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
