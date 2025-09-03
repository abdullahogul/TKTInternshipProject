namespace TktInternshipProject.Services.Interfaces;

public interface IJwtService
{
    string GenerateToken(User user);
}