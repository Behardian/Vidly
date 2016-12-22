namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'ebe0e1fd-6b13-4a93-bc5f-188afb166ae1', N'guest@vidly.com', 0, N'ALt9y5gppUMH3wMkjY68PsbC1ADOxsSAjLn4WyfycboRTy4GgekNOBXO1v+XSOapYA==', N'7f61cb4c-5264-4754-8bae-44ab19eaa2fa', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'f2b05146-c9ee-442e-883c-731b0e0bf940', N'admin@vidly.com', 0, N'ADFthxCDkzZMQTHSG0Skk0VG6N8qAoV7I8FuSOb6x9lNcr+pk5P9KibXAdiPTeUJdQ==', N'9062d699-18c4-412f-a10d-46b9da17a444', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'ba4cff68-0fe4-449c-9497-b17462fde104', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'f2b05146-c9ee-442e-883c-731b0e0bf940', N'ba4cff68-0fe4-449c-9497-b17462fde104')
");
        }
        
        public override void Down()
        {
        }
    }
}
