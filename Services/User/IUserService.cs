namespace Services.User;

public interface IUserService
{
    Task<Dtos.Models.User.Create.OutputDto> Create(Dtos.Models.User.Create.Service.InputDto iModel);
    Dtos.Models.User.Retrieve.OutputDto Retrieve();
}
