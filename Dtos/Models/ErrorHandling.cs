namespace Dtos.Models;

public class ErrorHandlingDto
{
    public int ErrorCode { get; set; }
    public string? ErrorMessage { get; set; }
    public string? ErrorTechnicalMessage { get; set; }
    public string? ErrorKey { get; set; }
    public bool? ErrorMustBeSeenByUser { get; set; } = true;
    public int? ErrorLogId { get; set; }
    public bool IsSuccessful => ErrorCode == 0;
}
