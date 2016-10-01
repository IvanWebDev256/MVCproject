namespace OdeToFood.Migrations
{
    using Models;
    using System.Collections.Generic;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<OdeToFood.Models.OdeToFoodDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "OdeToFood.Models.OdeToFoodDb";
        }

        protected override void Seed(OdeToFoodDb context)
        {
            context.Restaurants.AddOrUpdate(r => r.Name, // it looks by Name
                // if name exist it updates if not it add
                new Restaurant() { Name = "Sabatino's", City = "Baltimore", Country = "USA" },
                new Restaurant() { Name = "Grate Lake", City = "Chicago", Country = "USA"},
                new Restaurant()
                {
                    Name = "Smaka",
                    City = "Gothenberg",
                    Country = "Sweden",
                    Reviews = new List<RestaurantReview>
                    {
                        new RestaurantReview { Rating = 9, Body = "Great Food", ReviewerName = "Ivan" }
                    }
                }
                );
        }
    }
}
