namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'0f2b7c94-80be-4769-92d4-6318bff7e76d', N'admin@vidly.com', 0, N'AGfrLeHpKPZNh303lTErG7kaqP4gda3IhpkbQsA2tjcYd+x9kaVufDJj3er7/seQWQ==', N'7f16740b-4864-42c8-a070-2b77715e1ec7', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'8a367a4f-dbeb-47e4-a7a4-76f5dde589fd', N'guest@vidly.com', 0, N'AEot1chu+uKeGkZCobzmD3s9tJy8YnhMD3RZaXMaIZbEwAbK8RE3xc/nZMGhRwPnEw==', N'52e3059c-3006-437a-b171-883c87179622', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'648d77c5-7281-4dd1-b614-bd13b9bdad60', N'CanManageMovies')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'0f2b7c94-80be-4769-92d4-6318bff7e76d', N'648d77c5-7281-4dd1-b614-bd13b9bdad60')
");
        }
        
        public override void Down()
        {
        }
    }
}
