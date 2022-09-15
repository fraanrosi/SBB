using Ardalis.Specification;

namespace SBB.Core.Interfaces;

public interface IRepository<T> : IRepositoryBase<T> where T : class
{
}
