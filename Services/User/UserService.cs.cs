using Entities;
using Microsoft.EntityFrameworkCore;

namespace Services.User;

public class UserService: IUserService
{
    private readonly DatabaseContext _dbContext;
    public UserService(DatabaseContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<Dtos.Models.User.Create.OutputDto> Create(Dtos.Models.User.Create.Service.InputDto iModel)
    {
        try
        {
            var iData = new Entities.User
            {
                Email = iModel.Email,
                Password = iModel.Password,
                CreationDateTimeUtc = iModel.CreationDateTimeUtc
            };
            var result = await _dbContext.Users.AddAsync(iData);
            iData.Id=_dbContext.SaveChanges();
            return new Dtos.Models.User.Create.OutputDto
            {
                Data = new Dtos.Models.User.FullBaseDto
                {
                    Id = iData.Id,
                    Email = iData.Email,
                    Password = iData.Password,
                    CreationDateTimeUtc = iData.CreationDateTimeUtc
                }
            };
        }
        catch (Exception ex)
        {
            return new Dtos.Models.User.Create.OutputDto
            {
                ErrorHandling = new Dtos.Models.ErrorHandlingDto
                {
                    ErrorCode = 1,
                    ErrorMessage = ex.Message
                }
            };
        }
    }

    public Dtos.Models.User.Retrieve.OutputDto Retrieve()
    {
        try
        {
            var data = _dbContext.Users.Select(x => new Dtos.Models.User.FullBaseDto
            {
                Id = x.Id,
                Email = x.Email,
                Password = x.Password,
                CreationDateTimeUtc = x.CreationDateTimeUtc
            });
            return new Dtos.Models.User.Retrieve.OutputDto
            {
                Data = data
            };
        }
        catch (Exception ex)
        {
            return new Dtos.Models.User.Retrieve.OutputDto
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
