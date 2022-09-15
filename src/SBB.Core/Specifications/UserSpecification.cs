using Ardalis.Specification;
using SBB.Core.Entities;

namespace SBB.Core.Specifications
{
    public sealed class UserSpecification : Specification<User>, ISingleResultSpecification
    {
        public UserSpecification(int id)
        {
            Query
                .Where(b => b.Id == id);
        }
    }
}
