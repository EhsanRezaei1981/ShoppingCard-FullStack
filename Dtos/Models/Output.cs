using Dtos.Interfaces;

namespace Dtos.Models.Result;

public class Dto
{
    public ErrorHandlingDto ErrorHandling { get; set; }
    public Dto()
    {
        ErrorHandling = new ErrorHandlingDto();
    }
}
public class Dto<TModel> : Dto, IGenericData<TModel>
{
    public TModel Data { get; set; }
}

public class ListDto<TModel> : Dto, IGenericDataList<TModel> where TModel : class
{
    public long? TotalRecords { get; set; }
    public IEnumerable<TModel> Data { get; set; }
}
