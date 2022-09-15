using Ardalis.Specification;

namespace SBB.Core.Interfaces;

public interface IReadRepository<T> : IReadRepositoryBase<T> where T : class
{
}
