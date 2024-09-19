using API.Entities;
using Microsoft.AspNetCore.Identity;

namespace API.Data
{
    public static class DbInitializer
    {
        public static async Task Initialize(StoreContext context, UserManager<User> userManager)
        {
            if (!userManager.Users.Any())
            {
                var user = new User
                {
                    UserName = "abiyu",
                    Email = "abiyu@test.com"
                };

                await userManager.CreateAsync(user, "Pa$$w0rd");
                await userManager.AddToRoleAsync(user, "Member");

                var admin = new User
                {
                    UserName = "admin",
                    Email = "admin@test.com"
                };

                await userManager.CreateAsync(admin, "Pa$$w0rd");
                await userManager.AddToRolesAsync(admin, new[] { "Member", "Admin" });
            }

            if (context.Products.Any()) return;

            var products = new List<Product>
            {
                new Product
                {
                    Name = "Amaretto",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 1599,
                    PictureUrl = "/images/products/cake-amaretto.jpg",
                    Type = "Cake",
                }, new Product
                {
                    Name = "Alliance",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 1345,
                    PictureUrl = "/images/products/cake-alliance-morcov-ghimbir.jpg",
                    Type = "Cake",
                }, new Product
                {
                    Name = "Ambassador",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 1876,
                    PictureUrl = "/images/products/cake-ambassador.jpg",
                    Type = "Cake",
                }, new Product
                {
                    Name = "Belcolade",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 1187,
                    PictureUrl = "/images/products/cake-belcolade.png",
                    Type = "Cake",
                }, new Product
                {
                    Name = "Carmelita",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 1423,
                    PictureUrl = "/images/products/cake-carmelita.jpg",
                    Type = "Cake",
                }, new Product
                {
                    Name = "Cheesecake",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 1756,
                    PictureUrl = "/images/products/cake-cheesecake-tropiques.jpg",
                    Type = "Cake",
                }, new Product
                {
                    Name = "Cocoblanc",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 1289,
                    PictureUrl = "/images/products/cake-cocoblanc.jpg",
                    Type = "Cake",
                }, new Product
                {
                    Name = "Delicaramel",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 1632,
                    PictureUrl = "/images/products/cake-delicaramel.jpg",
                    Type = "Cake",
                }, new Product
                {
                    Name = "Diplomat",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 1987,
                    PictureUrl = "/images/products/cake-diplomat.jpg",
                    Type = "Cake",
                }, new Product
                {
                    Name = "Dom",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 1465,
                    PictureUrl = "/images/products/cake-dom-busuioc.png",
                    Type = "Cake",
                }, new Product
                {
                    Name = "Evening passion",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 1699,
                    PictureUrl = "/images/products/cake-evening-passion.jpg",
                    Type = "Cake",
                }, new Product
                {
                    Name = "Exotic passion",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 2032,
                    PictureUrl = "/images/products/cake-exotic-passion.jpg",
                    Type = "Cake",
                }, new Product
                {
                    Name = "Ecstatic",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 1387,
                    PictureUrl = "/images/products/cake-extaz.jpg",
                    Type = "Cake",
                }, new Product
                {
                    Name = "Mon amis",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 1745,
                    PictureUrl = "/images/products/cake-mon-amis.jpg",
                    Type = "Cake",
                }, new Product
                {
                    Name = "White mousse",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 1576,
                    PictureUrl = "/images/products/cake-mousse-alb-zmeura.jpg",
                    Type = "Cake",
                }, new Product
                {
                    Name = "Facile",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 1889,
                    PictureUrl = "/images/products/cake-mousse-lejer.jpg",
                    Type = "Cake",
                }, new Product
                {
                    Name = "Dark mousse",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 2254,
                    PictureUrl = "/images/products/cake-mousse-negru-menta-zmeura.jpg",
                    Type = "Cake",
                }, new Product
                {
                    Name = "Olivia",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 1636,
                    PictureUrl = "/images/products/cake-olivia.jpg",
                    Type = "Cake",
                }, new Product
                {
                    Name = "Oscar",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 1445,
                    PictureUrl = "/images/products/cake-oscar.jpg",
                    Type = "Cake",
                }, new Product
                {
                    Name = "Regina",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 1923,
                    PictureUrl = "/images/products/cake-regina.jpg",
                    Type = "Cake",
                }, new Product
                {
                    Name = "Richard",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 2399,
                    PictureUrl = "/images/products/cake-richard.jpg",
                    Type = "Cake",
                }, new Product
                {
                    Name = "Choux",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 249,
                    PictureUrl = "/images/products/choux.jpg",
                    Type = "Pastry",
                }, new Product
                {
                    Name = "Vanilla eclair",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 199,
                    PictureUrl = "/images/products/ecler-vanilie.jpg",
                    Type = "Pastry",
                }, new Product
                {
                    Name = "Coffee eclair",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 225,
                    PictureUrl = "/images/products/ecler-cafea.jpg",
                    Type = "Pastry",
                }, new Product
                {
                    Name = "Choc eclair",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 275,
                    PictureUrl = "/images/products/ecler-cioco.jpg",
                    Type = "Pastry",
                }, new Product
                {
                    Name = "Pistachio eclair",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 215,
                    PictureUrl = "/images/products/ecler-fistic.jpg",
                    Type = "Pastry",
                }, new Product
                {
                    Name = "Pink eclair",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 289,
                    PictureUrl = "/images/products/ecler-pink.jpg",
                    Type = "Pastry",
                }, new Product
                {
                    Name = "Chantilly",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 239,
                    PictureUrl = "/images/products/chantilly.jpg",
                    Type = "Mini cakes",
                }, new Product
                {
                    Name = "Bohemian",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 205,
                    PictureUrl = "/images/products/bohema.jpg",
                    Type = "Mini cakes",
                }, new Product
                {
                    Name = "Fruity",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 265,
                    PictureUrl = "/images/products/mini-fruit.jpg",
                    Type = "Mini cakes",
                }, new Product
                {
                    Name = "Mint mousse",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 150,
                    PictureUrl = "/images/products/mint-mousse.jpg",
                    Type = "Mini cakes",
                }, new Product
                {
                    Name = "Pistash",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 295,
                    PictureUrl = "/images/products/pistash-mousse.jpg",
                    Type = "Mini cakes",
                }, new Product
                {
                    Name = "Tropiques",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 175,
                    PictureUrl = "/images/products/tropiques.jpg",
                    Type = "Mini cakes",
                },
            };

            foreach (var product in products)
            {
                context.Products.Add(product);
            }

            context.SaveChanges();
        }
    }
}