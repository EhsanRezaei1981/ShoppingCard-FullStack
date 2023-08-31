using Dtos.Interfaces;

namespace Dtos.Models;

public class OutputDto
{
    public ErrorHandlingDto ErrorHandling { get; set; }
    public OutputDto()
    {
        ErrorHandling = new ErrorHandlingDto();
    }
}
public class OutputDto<TModel> : OutputDto, IGenericData<TModel>
{
    public TModel Data { get; set; }
}

public class OutputListDto<TModel> : OutputDto, IGenericDataList<TModel> where TModel : class
{
    public long? TotalRecords { get; set; }
    public IEnumerable<TModel> Data { get; set; }
}
