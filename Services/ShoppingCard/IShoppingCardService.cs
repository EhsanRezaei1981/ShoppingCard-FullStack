namespace Services.ShoppingCard;

public interface IShoppingCardService
{
    Task<Dtos.Models.ShoppingCard.Create.OutputDto> Create(Dtos.Models.RequestInfo requestInfo, Dtos.Models.ShoppingCard.Create.Service.InputDto iModel);
}
