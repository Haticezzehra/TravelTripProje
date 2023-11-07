namespace TravelTripProje.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Mig : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Blogs", "Baslik", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Blogs", "Baslik", c => c.String(nullable: false, maxLength: 50));
        }
    }
}
