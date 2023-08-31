
namespace Dtos.Interfaces;

public interface IGenericData<TModel>
{
    TModel Data { get; set; }
}
public interface IGenericDataList<TModel> where TModel : class
{
    long? TotalRecords { get; set; }
    IEnumerable<TModel> Data { get; set; }
}
