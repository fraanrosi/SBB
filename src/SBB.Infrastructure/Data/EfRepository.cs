using Ardalis.Specification.EntityFrameworkCore;
using SBB.Core.Interfaces;

namespace SBB.Infrastructure.Data;

public class EfRepository<T> : RepositoryBase<T>, IReadRepository<T>, IRepository<T> where T : class
{
    public EfRepository(SBBDBContext dbContext) : base(dbContext)
    {
    }

}
