namespace Taskms.Api.Services;

public interface IJwtService
{
    string GenerateToken(User user);
}