
namespace Dtos.Models;

public abstract class User
{
    public class Identity {
        public int Id { get; set; }
    }
    public class BaseDto
    {
        public required string Email { get; set; }
        public required string Password { get; set; }
    }
    public class FullBaseDto:BaseDto {
        public int Id { get; set; }
    }
}
