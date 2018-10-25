namespace TeduShop.Data.Migrations
{
    using Model.Models;
    using System.Collections.Generic;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<TeduShop.Data.TeduShopDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(TeduShop.Data.TeduShopDbContext context)
        {
            CreateProdcutCategorySample(context);
            //  This method will be called after migrating to the latest version.

            /*var manager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new TeduShopDbContext()));

            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(new TeduShopDbContext()));

            var user = new ApplicationUser()
            {
                UserName = "tedu",
                Email = "tedu.international@gmail.com",
                EmailConfirmed = true,
                BirthDay = DateTime.Now,
                FullName = "Technology Education"
            };

            manager.Create(user, "123654$");

            if (!roleManager.Roles.Any())
            {
                roleManager.Create(new IdentityRole { Name = "Admin" });
                roleManager.Create(new IdentityRole { Name = "User" });
            }

            var adminUser = manager.FindByEmail("tedu.international@gmail.com");

            manager.AddToRoles(adminUser.Id, new string[] { "Admin", "User" });*/
        }

        private void CreateProdcutCategorySample(TeduShop.Data.TeduShopDbContext context)
        {
            if (context.ProductCategories.Count() == 0)
            {
                List<ProductCategory> listProductCategory = new List<ProductCategory>()
            {
                new ProductCategory() {Name ="Điện lạnh",Alias="dien-lanh", Status=true },
                new ProductCategory() {Name ="Viễn Thông",Alias="vien-thong", Status=true },
                new ProductCategory() {Name ="Đồ Gia Dụng",Alias="d-da-dung", Status=true },
                new ProductCategory() {Name ="Mỹ Phẩm",Alias="m-p", Status=true },
            };
                context.ProductCategories.AddRange(listProductCategory);
                context.SaveChanges();
            };
        }
    }
}