namespace Dtos.Models;

public abstract class ShoppingCardDetail
{
    public interface IIdentity
    {
        int Id { get; set; }
    }
    public class Identity : IIdentity
    {
        public int Id { get; set; }
    }
    public class BaseDto
    {
        public int ShoppingCardId { get; set; }
        public int SaleItemId { get; set; }
        public int Count { get; set; }
        public decimal Fee { get; set; }
        public decimal TotalAmount { get; set; }
    }
    public class FullBaseDto : BaseDto, IIdentity
    {
        public int Id { get; set; }
    }

    public abstract class Create
    {
        public abstract class Api
        {
            public class InputDto : Identity
            {
                public required BaseDto ShoppingCardDetail { get; set; }
            }
        }
        public abstract class Service
        {
            public class InputDto : Api.InputDto { }
            public class OutputDto : Dtos.Models.Result.Dto { }
        }
    }

    public abstract class Update
    {
        public abstract class Api
        {
            public class InputDto : FullBaseDto
            {
            }
        }
        public abstract class Service
        {
            public class InputDto : Api.InputDto { }
            public class OutputDto : Dtos.Models.Result.Dto { }
        }
    }

    public abstract class Delete
    {
        public abstract class Api
        {
            public class InputDto : Identity
            {
            }
        }
        public abstract class Service
        {
            public class InputDto : Api.InputDto { }
            public class OutputDto : Dtos.Models.Result.Dto { }
        }
    }
}