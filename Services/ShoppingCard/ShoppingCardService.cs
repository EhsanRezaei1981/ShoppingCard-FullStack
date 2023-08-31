using Entities;

namespace Services.ShoppingCard;

public class ShoppingCardService: IShoppingCardService
{
    private readonly DatabaseContext _dbContext;
    public ShoppingCardService(DatabaseContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<Dtos.Models.ShoppingCard.Create.OutputDto> Create(Dtos.Models.RequestInfo requestInfo, Dtos.Models.ShoppingCard.Create.Service.InputDto iModel )
    {
        try
        {
            var result = await _dbContext.AddAsync(iModel);
            return new Dtos.Models.ShoppingCard.Create.OutputDto { };
        }
        catch (Exception ex)
        {
            return new Dtos.Models.ShoppingCard.Create.OutputDto
            {
                ErrorHandling = new Dtos.Models.ErrorHandlingDto
                {
                    ErrorCode = 1,
                    ErrorMessage = ex.Message
                }
            };
        }
    }
}
