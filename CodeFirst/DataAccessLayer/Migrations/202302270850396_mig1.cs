namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Admins",
                c => new
                    {
                        AdminID = c.Int(nullable: false, identity: true),
                        AdminName = c.String(maxLength: 50),
                        AdminSurname = c.String(maxLength: 50),
                        Password = c.String(maxLength: 20),
                        SignDate = c.DateTime(nullable: false),
                        ImageUrl = c.String(maxLength: 50),
                        Email = c.String(maxLength: 50),
                        AdminAccStatus = c.Boolean(nullable: false),
                        PermissionID = c.Int(),
                    })
                .PrimaryKey(t => t.AdminID)
                .ForeignKey("dbo.Permissions", t => t.PermissionID)
                .Index(t => t.PermissionID);
            
            CreateTable(
                "dbo.Permissions",
                c => new
                    {
                        PermissionID = c.Int(nullable: false, identity: true),
                        PermissionName = c.String(maxLength: 50),
                        PermissionStatus = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.PermissionID);
            
            CreateTable(
                "dbo.Branches",
                c => new
                    {
                        BranchID = c.Int(nullable: false, identity: true),
                        BranchName = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.BranchID);
            
            CreateTable(
                "dbo.Doctors",
                c => new
                    {
                        DoctorID = c.Int(nullable: false, identity: true),
                        DoctorName = c.String(maxLength: 50),
                        DoctorSurname = c.String(maxLength: 50),
                        DrAccStatus = c.Boolean(nullable: false),
                        BranchID = c.Int(),
                        HospitalID = c.Int(),
                        PermissionID = c.Int(),
                    })
                .PrimaryKey(t => t.DoctorID)
                .ForeignKey("dbo.Branches", t => t.BranchID)
                .ForeignKey("dbo.Hospitals", t => t.HospitalID)
                .ForeignKey("dbo.Permissions", t => t.PermissionID)
                .Index(t => t.BranchID)
                .Index(t => t.HospitalID)
                .Index(t => t.PermissionID);
            
            CreateTable(
                "dbo.Hospitals",
                c => new
                    {
                        HospitalID = c.Int(nullable: false, identity: true),
                        HospitalName = c.String(maxLength: 50),
                        CityID = c.Int(),
                    })
                .PrimaryKey(t => t.HospitalID)
                .ForeignKey("dbo.Cities", t => t.CityID)
                .Index(t => t.CityID);
            
            CreateTable(
                "dbo.Cities",
                c => new
                    {
                        CityID = c.Int(nullable: false, identity: true),
                        CityName = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.CityID);
            
            CreateTable(
                "dbo.CustomerReports",
                c => new
                    {
                        ReportID = c.Int(nullable: false, identity: true),
                        CustomerID = c.Int(),
                        DoctorID = c.Int(),
                        HospitalID = c.Int(),
                        GuestID = c.Int(),
                        Disease = c.String(),
                        SignDate = c.DateTime(nullable: false),
                        Price = c.String(maxLength: 20),
                        Treatment = c.String(maxLength: 20),
                        ExpireDate = c.DateTime(nullable: false),
                        ReportStatus = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ReportID)
                .ForeignKey("dbo.Customers", t => t.CustomerID)
                .ForeignKey("dbo.Doctors", t => t.DoctorID)
                .ForeignKey("dbo.Guests", t => t.GuestID)
                .ForeignKey("dbo.Hospitals", t => t.HospitalID)
                .Index(t => t.CustomerID)
                .Index(t => t.DoctorID)
                .Index(t => t.HospitalID)
                .Index(t => t.GuestID);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        CustomerID = c.Int(nullable: false, identity: true),
                        CustomerName = c.String(maxLength: 50),
                        CustomerSurname = c.String(maxLength: 50),
                        CustomerTC = c.String(maxLength: 12),
                        SignDate = c.DateTime(nullable: false),
                        Password = c.String(maxLength: 50),
                        Email = c.String(maxLength: 50),
                        ImageUrl = c.String(maxLength: 50),
                        AccStatus = c.Boolean(nullable: false),
                        PermissionID = c.Int(),
                        HospitalID = c.Int(),
                        GuestID = c.Int(),
                        Hospital_PermissionID = c.Int(),
                        Permission_PermissionID = c.Int(),
                    })
                .PrimaryKey(t => t.CustomerID)
                .ForeignKey("dbo.Guests", t => t.GuestID)
                .ForeignKey("dbo.Permissions", t => t.Hospital_PermissionID)
                .ForeignKey("dbo.Permissions", t => t.Permission_PermissionID)
                .Index(t => t.GuestID)
                .Index(t => t.Hospital_PermissionID)
                .Index(t => t.Permission_PermissionID);
            
            CreateTable(
                "dbo.Guests",
                c => new
                    {
                        GuestID = c.Int(nullable: false, identity: true),
                        GuestName = c.String(maxLength: 50),
                        GuestSurname = c.String(maxLength: 50),
                        GuestTC = c.String(maxLength: 50),
                        Email = c.String(maxLength: 50),
                        Password = c.String(maxLength: 50),
                        GuestAccStatus = c.Boolean(nullable: false),
                        PermissionID = c.Int(),
                    })
                .PrimaryKey(t => t.GuestID)
                .ForeignKey("dbo.Permissions", t => t.PermissionID)
                .Index(t => t.PermissionID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CustomerReports", "HospitalID", "dbo.Hospitals");
            DropForeignKey("dbo.CustomerReports", "GuestID", "dbo.Guests");
            DropForeignKey("dbo.CustomerReports", "DoctorID", "dbo.Doctors");
            DropForeignKey("dbo.CustomerReports", "CustomerID", "dbo.Customers");
            DropForeignKey("dbo.Customers", "Permission_PermissionID", "dbo.Permissions");
            DropForeignKey("dbo.Customers", "Hospital_PermissionID", "dbo.Permissions");
            DropForeignKey("dbo.Customers", "GuestID", "dbo.Guests");
            DropForeignKey("dbo.Guests", "PermissionID", "dbo.Permissions");
            DropForeignKey("dbo.Doctors", "PermissionID", "dbo.Permissions");
            DropForeignKey("dbo.Doctors", "HospitalID", "dbo.Hospitals");
            DropForeignKey("dbo.Hospitals", "CityID", "dbo.Cities");
            DropForeignKey("dbo.Doctors", "BranchID", "dbo.Branches");
            DropForeignKey("dbo.Admins", "PermissionID", "dbo.Permissions");
            DropIndex("dbo.Guests", new[] { "PermissionID" });
            DropIndex("dbo.Customers", new[] { "Permission_PermissionID" });
            DropIndex("dbo.Customers", new[] { "Hospital_PermissionID" });
            DropIndex("dbo.Customers", new[] { "GuestID" });
            DropIndex("dbo.CustomerReports", new[] { "GuestID" });
            DropIndex("dbo.CustomerReports", new[] { "HospitalID" });
            DropIndex("dbo.CustomerReports", new[] { "DoctorID" });
            DropIndex("dbo.CustomerReports", new[] { "CustomerID" });
            DropIndex("dbo.Hospitals", new[] { "CityID" });
            DropIndex("dbo.Doctors", new[] { "PermissionID" });
            DropIndex("dbo.Doctors", new[] { "HospitalID" });
            DropIndex("dbo.Doctors", new[] { "BranchID" });
            DropIndex("dbo.Admins", new[] { "PermissionID" });
            DropTable("dbo.Guests");
            DropTable("dbo.Customers");
            DropTable("dbo.CustomerReports");
            DropTable("dbo.Cities");
            DropTable("dbo.Hospitals");
            DropTable("dbo.Doctors");
            DropTable("dbo.Branches");
            DropTable("dbo.Permissions");
            DropTable("dbo.Admins");
        }
    }
}
