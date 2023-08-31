

namespace Dtos.Models;

public abstract class User
{
    public class Identity {
        public int Id { get; set; }
    }

    public interface IBaseDto
    {
        public string? Email { get; set; }
        public string? Password { get; set; }
    }

    public class BaseDto: IBaseDto
    {        
        public string? Email { get; set; }
        public string? Password { get; set; }
    }

    public interface ICreationDateTime {
        public DateTime CreationDateTimeUtc { get; set; }
    }

    public class FullBaseDto:BaseDto, ICreationDateTime
    {
        public int Id { get; set; }
        public DateTime CreationDateTimeUtc { get; set; }
    }
    
    public abstract class Create {
        public abstract class Api
        {
            public class InputDto : IBaseDto
            {
                public virtual required string? Email { get; set; }
                public virtual required string? Password { get; set; }
            }
        }
        public abstract class Service
        {
            public class InputDto : Api.InputDto, ICreationDateTime
            {
                public override required string? Email { get; set; }
                public override required string? Password { get; set; }
                public required DateTime CreationDateTimeUtc { get; set; }
            }
        }
        public class OutputDto:Dtos.Models.Result.Dto<FullBaseDto>{ }
    }

    public abstract class Retrieve
    {
        public class OutputDto : Dtos.Models.Result.ListDto<FullBaseDto> { }
    }
}
