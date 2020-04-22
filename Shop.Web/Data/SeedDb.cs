using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Shop.Web.Data;
using Shop.Web.Data.Entities;

public class SeedDb
{
    private readonly DataContext context;
    private readonly UserManager<User> userManager;
    private Random random;


    public SeedDb(DataContext context, UserManager<User> userManager)
    {
        this.context = context;
        this.userManager = userManager;
        this.random = new Random();
    }

    public async Task SeedAsync()
    {
        await this.context.Database.EnsureCreatedAsync();

        var user = await this.userManager.FindByEmailAsync("rayct76@gmail.com");
        if (user == null)
        {
            user = new User
            {
                FirstName = "Ray",
                LastName = "Chavez",
                Email = "rayct76@gmail.com",
                UserName = "rayct76@gmail.com"
            };

            var result = await this.userManager.CreateAsync(user, "123456");
            if (result != IdentityResult.Success)
            {
                throw new InvalidOperationException("Could not create the user in seeder");
            }
        }

        if (!this.context.Products.Any())
        {
            this.AddProduct("First Product", user);
            this.AddProduct("Second Product", user);
            this.AddProduct("Third Product", user);
            await this.context.SaveChangesAsync();
        }
    }

    private void AddProduct(string name, User user)
    {
        this.context.Products.Add(new Product
        {
            Name = name,
            Price = this.random.Next(100),
            IsAvailabe = true,
            Stock = this.random.Next(100),
            User = user
        });
    }
}
