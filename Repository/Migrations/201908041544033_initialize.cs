namespace RepositoryPattern.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialize : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Devices",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Developer = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.People",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Birthday = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PeopleDevices",
                c => new
                    {
                        People_Id = c.Int(nullable: false),
                        Device_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.People_Id, t.Device_Id })
                .ForeignKey("dbo.People", t => t.People_Id, cascadeDelete: true)
                .ForeignKey("dbo.Devices", t => t.Device_Id, cascadeDelete: true)
                .Index(t => t.People_Id)
                .Index(t => t.Device_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PeopleDevices", "Device_Id", "dbo.Devices");
            DropForeignKey("dbo.PeopleDevices", "People_Id", "dbo.People");
            DropIndex("dbo.PeopleDevices", new[] { "Device_Id" });
            DropIndex("dbo.PeopleDevices", new[] { "People_Id" });
            DropTable("dbo.PeopleDevices");
            DropTable("dbo.People");
            DropTable("dbo.Devices");
        }
    }
}
