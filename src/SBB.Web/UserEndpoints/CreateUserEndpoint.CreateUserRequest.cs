using SBB.Web;

namespace SBB.Web;

public class CreateUserRequest : BaseRequest
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Email { get; set; }
    public string? LastName { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime LastModifiedDate { get; set; }
    public int Age { get; set; }
}
