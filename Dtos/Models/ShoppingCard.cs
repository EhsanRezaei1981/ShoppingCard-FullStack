
namespace Dtos.Models;

public abstract class ShoppingCard
{
    public class Identity
    {
        public int Id { get; set; }
    }
    public class BaseDto
    {
        public DateTime DateTimeUtc { get; set; }
        public decimal TotalAmount { get; set; }
    }

    public class FullBaseDto:BaseDto {
        public int Id { get; set; }
    }

    public abstract class Create
    {
        public abstract class Api
        {
            public class InputDto : BaseDto
            {
                public IEnumerable<ShoppingCardDetail>? ShoppingCardDetails { get; set; }
            }
        }
        public abstract class Service
        {
            public class InputDto : Api.InputDto { }            
        }
        public class OutputDto : Dtos.Models.Result.Dto { }
    }

    public abstract class Delete
    {
        public abstract class Api
        {
            public class InputDto : Identity{}
        }
        public abstract class Service
        {
            public class InputDto : Api.InputDto { }
            public class OutputDto : Dtos.Models.Result.Dto { }
        }
    }   
}
