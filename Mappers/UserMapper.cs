namespace TktInternshipProject.Mappers;

public class UserMapper
{
    public static UserDTO ToDTO(User user, Department department)
    {
        return new UserDTO
        {
            Id = user.Id,
            Name = user.Name,
            Surname = user.Surname,
            Email = user.Email,
            Title = user.Title,
            Department = user.Department.Name,
            Role = user.Role
        };
    }

    public static void UpdateEntity(User user, UserLoginDTO dto)
    {
        user.Password = dto.Password;
    }
}
