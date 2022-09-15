using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using SBB.Core.Entities;
using System.Xml.Linq;

namespace SBB.Infrastructure.Data;

public class SBBDBContextSeed
{
    public static async Task SeedAsync(SBBDBContext context,
        ILogger logger,
        int retry = 0)
    {
        var retryForAvailability = retry;
        try
        {
            if (context.Database.IsSqlServer())
            {
                context.Database.Migrate();
            }

            if (!await context.Users.AnyAsync())
            {
                await context.Users.AddRangeAsync(
                    GetPreconfiguredCatalogBrands());

                await context.SaveChangesAsync();
            }

        }
        catch (Exception ex)
        {
            if (retryForAvailability >= 10) throw;

            retryForAvailability++;
            
            logger.LogError(ex.Message);
            await SeedAsync(context, logger, retryForAvailability);
            throw;
        }
    }

    static IEnumerable<User> GetPreconfiguredCatalogBrands()
    {
        return new List<User>
            {
                new("Franco","asdñfasdf@gmail.com", "Rosi", new DateTime{}, new DateTime{}, 28)
            };
    }
}
