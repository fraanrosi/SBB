using MinimalApi.Endpoint;
using SBB.Core.Entities;
using SBB.Core.Interfaces;

namespace SBB.Web.UserEndpoints;

/// <summary>
/// Creates a new Catalog Item
/// </summary>
public class CreateUserEndpoint : IEndpoint<IResult, CreateUserRequest>
{
    private IRepository<User> _userRepository;
    private readonly IUriComposer _uriComposer;

    public CreateUserEndpoint(IUriComposer uriComposer)
    {
        _uriComposer = uriComposer;
    }

    public void AddRoute(IEndpointRouteBuilder app)
    {
        app.MapPost("api/users",
            (CreateUserRequest request, IRepository<User> userRepository) =>
            {
                _userRepository = userRepository;
                return HandleAsync(request);
            })
            .Produces<CreateUserResponse>()
            .WithTags("CatalogItemEndpoints");
            
        //    app.MapPost("api/catalog-items",
        //        [Authorize(Roles = BlazorShared.Authorization.Constants.Roles.ADMINISTRATORS, AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)] async
        //        (CreateUserRequest request, IRepository<User> itemRepository) =>
        //        {
        //            _itemRepository = itemRepository;
        //            return await HandleAsync(request);
        //        })
        //        .Produces<CreateCatalogItemResponse>()
        //        .WithTags("CatalogItemEndpoints");
    }

    public Task<IResult> HandleAsync(CreateUserRequest request)
    {
        var response = new CreateUserResponse(request.CorrelationId());

        //    var catalogItemNameSpecification = new CatalogItemNameSpecification(request.Name);
        //    var existingCataloogItem = await _itemRepository.CountAsync(catalogItemNameSpecification);
        //    if (existingCataloogItem > 0)
        //    {
        //        throw new DuplicateException($"A catalogItem with name {request.Name} already exists");
        //    }

        //    var newItem = new CatalogItem(request.CatalogTypeId, request.CatalogBrandId, request.Description, request.Name, request.Price, request.PictureUri);
        //    newItem = await _itemRepository.AddAsync(newItem);

        //    if (newItem.Id != 0)
        //    {
        //        //We disabled the upload functionality and added a default/placeholder image to this sample due to a potential security risk 
        //        //  pointed out by the community. More info in this issue: https://github.com/dotnet-architecture/eShopOnWeb/issues/537 
        //        //  In production, we recommend uploading to a blob storage and deliver the image via CDN after a verification process.

        //        newItem.UpdatePictureUri("eCatalog-item-default.png");
        //        await _itemRepository.UpdateAsync(newItem);
        //    }

        //    var dto = new CatalogItemDto
        //    {
        //        Id = newItem.Id,
        //        CatalogBrandId = newItem.CatalogBrandId,
        //        CatalogTypeId = newItem.CatalogTypeId,
        //        Description = newItem.Description,
        //        Name = newItem.Name,
        //        PictureUri = _uriComposer.ComposePicUri(newItem.PictureUri),
        //        Price = newItem.Price
        //    };
        //    response.CatalogItem = dto;
        //return Results.Created($"api/catalog-items/{dto.Id}", response);       
        return Task.FromResult(Results.Created($"api/users/", new CreateUserResponse()));
    }
}
