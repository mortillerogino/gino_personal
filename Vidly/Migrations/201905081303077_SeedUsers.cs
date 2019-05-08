namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'0a886ce6-fc9c-45af-b59a-ce0634cd18d6', N'guest@vidly.com', 0, N'ADIUrRTm9wGoIbng0GQDeFebt5S4DGVKAeODBhM9W/umCkHXcD9d3C/zI5Y1BABWPw==', N'27689e89-87e8-4234-8bcb-3b531ad8e6e0', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'b2abeb9c-52c9-45d4-8222-e1c55d015cac', N'admin@vidly.com', 0, N'ADxGP8aSl/JKbior0eUK76ArKUUmgHH5oy9zAfe2DmdvVgJqHpuRN3F22eL9M0G5zw==', N'bfdf1fce-6cf2-449e-ab19-151cbcf1fcd1', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
          
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'02c26e3b-deef-4388-8e4d-8b5115637ab3', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'b2abeb9c-52c9-45d4-8222-e1c55d015cac', N'02c26e3b-deef-4388-8e4d-8b5115637ab3')
");
        }
        
        public override void Down()
        {
        }
    }
}
