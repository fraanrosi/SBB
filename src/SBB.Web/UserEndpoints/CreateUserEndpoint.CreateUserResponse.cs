namespace SBB.Web;

public class CreateUserResponse : BaseResponse
{
    public CreateUserResponse(Guid correlationId) : base(correlationId)
    {
    }

    public CreateUserResponse()
    {
    }

    public UserDto User { get; set; }
}
