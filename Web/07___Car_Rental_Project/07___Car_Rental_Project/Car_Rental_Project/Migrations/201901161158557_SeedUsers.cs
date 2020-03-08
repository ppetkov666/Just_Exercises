namespace Car_Rental_Project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@" 
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'08097c88-18c6-4149-b335-2d9f747059eb', N'ptpetkov666@gmail.com', 0, N'AJiynP9MuY2pZmG8LaRnsNd2749/0wFTzlJRI5TzGYH+JirkXPdvPN2u8JWDOC63tA==', N'68b7df59-60f6-4406-a63a-1101c22a532f', NULL, 0, 0, NULL, 1, 0, N'ptpetkov666@gmail.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'109c332f-d639-4f83-90d2-a488d23a0e82', N'pesho@pesho.com', 0, N'AGrYMmm1CHzfDtXG8gfmwCLSj/NcJXKcXQp0US8M2Yt3vX3WRQ4FuvdNRWXjwwHzsw==', N'828619a2-216b-47ef-b75b-bad53a7ed727', NULL, 0, 0, NULL, 1, 0, N'pesho@pesho.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'cf52e37f-8c34-4091-b8b9-a421e48953f5', N'ptpetkov6667@gmail.com', 0, N'AJE7IexYQ/6N7Zfm5IlMXiKfR0ECdnUsMMxoFEtZiYIUH/cAlVH0GnkNIG5AmI8RJw==', N'c3393508-f64d-4bdf-83e9-b65975dbd7ea', NULL, 0, 0, NULL, 1, 0, N'ptpetkov6667@gmail.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'f3d135e3-3293-4ec1-a3dc-82266cfbafa5', N'new@new.com', 0, N'AHETMgfhSvTXfZc0qI1HGEXHzBNurAbqZhjLx15mvOR9FS2ItbZRIzmQ2Ht45eKwgw==', N'12e7ae67-4467-4bea-a681-46b5b70394c6', NULL, 0, 0, NULL, 1, 0, N'new@new.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'f4dca369-0268-4bb4-9bba-75236d975c56', N'admin@carRental.com', 0, N'ALei/xOJdjfsdpcU4tkVrcaS6ogE24tkAo5I8dtJwOxw1nBrLSy5ozaD/AfrO3IpYA==', N'59ddcc8e-a646-498f-a0b9-d86c47244cf1', NULL, 0, 0, NULL, 1, 0, N'admin@carRental.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'fa6fedcb-5c9c-472f-a285-c4861a993509', N'ivan@ivan.com', 0, N'AFD1j/UoabcHJRPPTfqGbp55AEP2G/WgqSxmQHfwMKmAN52+Av1KflNJw8JFplWMCg==', N'ef95b660-821e-4353-8174-7ff1ec84a0de', NULL, 0, 0, NULL, 1, 0, N'ivan@ivan.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'41c52165-39ba-4b8b-b588-406d339b729b', N'CanDeleteRentedTableRecords')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'f4dca369-0268-4bb4-9bba-75236d975c56', N'41c52165-39ba-4b8b-b588-406d339b729b')

");
        }

        public override void Down()
        {
        }
    }
}
