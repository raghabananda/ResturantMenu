using api.Models;

namespace api.Data;

public static class DataStore
{
    public static readonly List<Category> Categories = new()
    {
        new Category { Id = 1, Name = "Appetizers",  Description = "Exquisite starters to awaken your palate" },
        new Category { Id = 2, Name = "Main Course",  Description = "Signature entrées crafted by our master chefs" },
        new Category { Id = 3, Name = "Desserts",     Description = "Divine sweet endings to your culinary journey" },
        new Category { Id = 4, Name = "Beverages",    Description = "Premium beverages from around the world" },
        new Category { Id = 5, Name = "Specials",     Description = "Exclusive chef's table selections — available nightly" }
    };

    public static readonly List<MenuItem> MenuItems = new()
    {
        // Appetizers
        new MenuItem
        {
            Id = 1, Name = "Saffron-Scented Lobster Bisque",
            Description = "Velvety bisque of Maine lobster, infused with Persian saffron, crème fraîche, and chive oil.",
            Price = 28.00m, Category = "Appetizers",
            ImageUrl = "https://images.unsplash.com/photo-1547592166-23ac45744acd?w=800",
            IsAvailable = true, IsChefSpecial = true
        },
        new MenuItem
        {
            Id = 2, Name = "Truffle Burrata",
            Description = "Hand-pulled burrata, black truffle shavings, heirloom tomatoes, and aged balsamic reduction.",
            Price = 24.00m, Category = "Appetizers",
            ImageUrl = "https://images.unsplash.com/photo-1555396273-367ea4eb4db5?w=800",
            IsAvailable = true, IsChefSpecial = false
        },
        new MenuItem
        {
            Id = 3, Name = "Foie Gras Torchon",
            Description = "Artisanal foie gras with brioche toast, Sauternes gelée, and candied Sicilian pistachios.",
            Price = 36.00m, Category = "Appetizers",
            ImageUrl = "https://images.unsplash.com/photo-1414235077428-338989a2e8c0?w=800",
            IsAvailable = true, IsChefSpecial = true
        },
        new MenuItem
        {
            Id = 4, Name = "Tiger Prawn Cocktail",
            Description = "Chilled tiger prawns with house-made cocktail sauce, micro herbs, and lemon caviar.",
            Price = 22.00m, Category = "Appetizers",
            ImageUrl = "https://images.unsplash.com/photo-1565299585323-38d6b0865b47?w=800",
            IsAvailable = true, IsChefSpecial = false
        },

        // Main Course
        new MenuItem
        {
            Id = 5, Name = "Wagyu Beef Tenderloin",
            Description = "Grade A5 Wagyu tenderloin, truffle jus, pomme purée, and seasonal forest mushrooms.",
            Price = 120.00m, Category = "Main Course",
            ImageUrl = "https://images.unsplash.com/photo-1558030006-450675393462?w=800",
            IsAvailable = true, IsChefSpecial = true
        },
        new MenuItem
        {
            Id = 6, Name = "Pan-Seared Atlantic Halibut",
            Description = "Wild-caught halibut, champagne beurre blanc, asparagus ribbons, and caviar garnish.",
            Price = 68.00m, Category = "Main Course",
            ImageUrl = "https://images.unsplash.com/photo-1519708227418-c8fd9a32b7a2?w=800",
            IsAvailable = true, IsChefSpecial = false
        },
        new MenuItem
        {
            Id = 7, Name = "Roasted Rack of Lamb",
            Description = "New Zealand lamb rack, pistachio herb crust, rosemary jus, and gratin dauphinois.",
            Price = 88.00m, Category = "Main Course",
            ImageUrl = "https://images.unsplash.com/photo-1544025162-d76694265947?w=800",
            IsAvailable = true, IsChefSpecial = false
        },
        new MenuItem
        {
            Id = 8, Name = "Butter-Poached Maine Lobster",
            Description = "Whole Maine lobster, drawn butter, saffron risotto, and herb-infused lobster bisque.",
            Price = 95.00m, Category = "Main Course",
            ImageUrl = "https://images.unsplash.com/photo-1559742811-822873691df8?w=800",
            IsAvailable = true, IsChefSpecial = true
        },
        new MenuItem
        {
            Id = 9, Name = "Saffron-Braised Short Rib",
            Description = "48-hour braised wagyu short rib, pearl onion, roasted bone marrow, and horseradish cream.",
            Price = 72.00m, Category = "Main Course",
            ImageUrl = "https://images.unsplash.com/photo-1432139509613-5c4255815697?w=800",
            IsAvailable = true, IsChefSpecial = false
        },
        new MenuItem
        {
            Id = 10, Name = "Truffle Tagliatelle",
            Description = "Hand-rolled egg tagliatelle, shaved black Périgord truffle, Parmigiano-Reggiano, and cultured butter.",
            Price = 52.00m, Category = "Main Course",
            ImageUrl = "https://images.unsplash.com/photo-1473093226555-0c31f7afc1b3?w=800",
            IsAvailable = true, IsChefSpecial = false
        },

        // Desserts
        new MenuItem
        {
            Id = 11, Name = "Valrhona Chocolate Soufflé",
            Description = "Warm dark-chocolate soufflé with Madagascan vanilla bean ice cream and gold leaf.",
            Price = 22.00m, Category = "Desserts",
            ImageUrl = "https://images.unsplash.com/photo-1551024601-bec78aea704b?w=800",
            IsAvailable = true, IsChefSpecial = true
        },
        new MenuItem
        {
            Id = 12, Name = "Crème Brûlée Royale",
            Description = "Tahitian vanilla custard, caramelized sugar dome, seasonal berry compote.",
            Price = 18.00m, Category = "Desserts",
            ImageUrl = "https://images.unsplash.com/photo-1488477181946-6428a0291777?w=800",
            IsAvailable = true, IsChefSpecial = false
        },
        new MenuItem
        {
            Id = 13, Name = "Mango & Passion Fruit Pavlova",
            Description = "Crisp meringue, whipped mascarpone, Alphonso mango, and passion fruit coulis.",
            Price = 20.00m, Category = "Desserts",
            ImageUrl = "https://images.unsplash.com/photo-1464349095431-e9a21285b5f3?w=800",
            IsAvailable = true, IsChefSpecial = false
        },
        new MenuItem
        {
            Id = 14, Name = "Selection of Artisan Cheeses",
            Description = "Curated board of fine cheeses, honeycomb, fig jam, candied walnuts, and water crackers.",
            Price = 26.00m, Category = "Desserts",
            ImageUrl = "https://images.unsplash.com/photo-1452195100486-9cc805987862?w=800",
            IsAvailable = true, IsChefSpecial = false
        },

        // Beverages
        new MenuItem
        {
            Id = 15, Name = "Dom Pérignon Vintage 2013",
            Description = "An iconic champagne offering notes of almonds, citrus zest, and mineral elegance. 750 ml.",
            Price = 320.00m, Category = "Beverages",
            ImageUrl = "https://images.unsplash.com/photo-1510812431401-41d2bd2722f3?w=800",
            IsAvailable = true, IsChefSpecial = false
        },
        new MenuItem
        {
            Id = 16, Name = "Signature Saffron Martini",
            Description = "Grey Goose vodka, Persian saffron infusion, elderflower liqueur, and fresh lemon.",
            Price = 28.00m, Category = "Beverages",
            ImageUrl = "https://images.unsplash.com/photo-1514362545857-3bc16c4c7d1b?w=800",
            IsAvailable = true, IsChefSpecial = true
        },
        new MenuItem
        {
            Id = 17, Name = "Rare Single-Malt Collection",
            Description = "Curated dram of Macallan 18, Dalmore 15, or Glenfarclas 21 — served with hand-carved ice.",
            Price = 45.00m, Category = "Beverages",
            ImageUrl = "https://images.unsplash.com/photo-1527281400683-1aae777175f8?w=800",
            IsAvailable = true, IsChefSpecial = false
        },
        new MenuItem
        {
            Id = 18, Name = "Ceremonial Matcha Ritual",
            Description = "Japanese ceremonial-grade matcha whisked tableside, served with seasonal wagashi confection.",
            Price = 18.00m, Category = "Beverages",
            ImageUrl = "https://images.unsplash.com/photo-1556679343-c7306c1976bc?w=800",
            IsAvailable = true, IsChefSpecial = false
        },

        // Specials
        new MenuItem
        {
            Id = 19, Name = "Taj Heritage Tasting Menu",
            Description = "Seven-course culinary journey: amuse-bouche, two starters, sorbet, main, cheese, and dessert — paired with fine wines.",
            Price = 295.00m, Category = "Specials",
            ImageUrl = "https://images.unsplash.com/photo-1414235077428-338989a2e8c0?w=800",
            IsAvailable = true, IsChefSpecial = true
        },
        new MenuItem
        {
            Id = 20, Name = "Beluga Caviar Service",
            Description = "30 g Beluga caviar served with blinis, crème fraîche, and Billecart-Salmon Blanc de Blancs.",
            Price = 380.00m, Category = "Specials",
            ImageUrl = "https://images.unsplash.com/photo-1607623814075-e51df1bdc82f?w=800",
            IsAvailable = true, IsChefSpecial = true
        },
        new MenuItem
        {
            Id = 21, Name = "Gold-Leaf Wagyu Burger",
            Description = "A5 Wagyu patty, 24-karat gold leaf, black truffle aioli, aged cheddar, and brioche bun.",
            Price = 85.00m, Category = "Specials",
            ImageUrl = "https://images.unsplash.com/photo-1568901346375-23c9450c58cd?w=800",
            IsAvailable = true, IsChefSpecial = true
        }
    };

    private static int _nextReservationId = 1;
    private static readonly object _lock = new();

    public static List<Reservation> Reservations { get; } = new();

    public static Reservation AddReservation(Reservation reservation)
    {
        lock (_lock)
        {
            reservation.Id = _nextReservationId++;
            reservation.CreatedAt = DateTime.UtcNow;
            Reservations.Add(reservation);
            return reservation;
        }
    }

    public static Reservation? UpdateReservationStatus(int id, ReservationStatus status)
    {
        lock (_lock)
        {
            var reservation = Reservations.FirstOrDefault(r => r.Id == id);
            if (reservation is null) return null;
            reservation.Status = status;
            return reservation;
        }
    }
}
