using BackgroundServiceExample.Data;
using BackgroundServiceExample.Models;

namespace PlatformService.Data
{
    public static class PrepDb
    {
        public static void PrepPopulation(IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.CreateScope())
            {
                SeedData(serviceScope.ServiceProvider.GetService<AppDbContext>());
            }
        }

        private static void SeedData(AppDbContext context)
        {
            if (!context.Users.Any())
            {
                Console.WriteLine("--> Seeding Data...");
                
                var users = new List<User>();
                
                for (int i = 0; i < 100; i++)
                {
                    users.Add(new User() 
                    { 
                        Id = Guid.NewGuid(),
                        Name = Faker.Name.First() 
                    }
                    );
                }

                context.Users.AddRange(users);

                context.SaveChanges();
            }
            else
            {
                Console.WriteLine("--> We already have data");
            }
        }
    }
}
