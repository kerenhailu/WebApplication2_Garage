namespace WebApplication2_Garage.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateTableCar : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cars",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        NameOwner = c.String(),
                        NumCar = c.Int(nullable: false),
                        Status = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Cars");
        }
    }
}
