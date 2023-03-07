namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig2 : DbMigration
    {
        public override void Up()
        {
            //CreateTable(
            //    "dbo.ImageUrls",
            //    c => new
            //    {
            //        ImageID = c.Int(nullable: false, identity: true),
            //        ImageUrl = c.String(maxLength: 50),
            //        CustomerID = c.String(maxLength: 50),
            //        Password = c.String(maxLength: 20),
            //        SignDate = c.DateTime(nullable: false),
            //        ImageUrl = c.String(maxLength: 50),
            //        Email = c.String(maxLength: 50),
            //        AdminAccStatus = c.Boolean(nullable: false),
            //        PermissionID = c.Int(),
            //    })
            //    .PrimaryKey(t => t.AdminID)
            //    .ForeignKey("dbo.Permissions", t => t.PermissionID)
            //    .Index(t => t.PermissionID);
        }
        
        public override void Down()
        {
        }
    }
}
