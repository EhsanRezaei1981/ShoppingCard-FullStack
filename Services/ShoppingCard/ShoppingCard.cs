using Entities;

namespace Services.ShoppingCard;

public class ShoppingCard
{
    private readonly DatabaseContext _dbContext;
    public ShoppingCard(DatabaseContext dbContext)
    {
        _dbContext = dbContext;
    }

    //public async Task<Dtos.Models.ShoppingCard.Create.Service.OutputDto> Create(Dtos.Models.RequestInfo requestInfo, Dtos.Models.ShoppingCard.Create.Service.OutputDto iModel)
    //{
    //    try {
    //        var result=await _dbContext.AddAsync(iModel);
    //    } 
    //    catch (Exception ex) {
    //        return new Dtos.Models.ShoppingCard.Create.Service.OutputDto
    //        {
    //            ErrorHandling = new Dtos.Models.ErrorHandlingDto
    //            {
    //                ErrorCode = 1,
    //                ErrorMessage = ex.Message
    //            }
    //        };
    //    }
    //}
}
