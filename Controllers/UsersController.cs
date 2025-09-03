namespace TktInternshipProject.Controllers;

[Route("Users")]
[ApiController]
public class UsersController(ApplicationDbContext db, IJwtService jwtService, IPasswordHasherService passwordHasherService) : ControllerBase
{
    private readonly ApplicationDbContext _db = db;
    private readonly IJwtService _jwtService = jwtService;
    private readonly IPasswordHasherService _passwordHasherService = passwordHasherService;

    [HttpPost("Login")]
    public async Task<ActionResult> Login([FromBody] UserLoginDTO loginDto)
    {
        var user = await _db.Users.FirstOrDefaultAsync(u => u.Email == loginDto.Email);

        if (user == null)
            return Unauthorized("Email is incorrect");

        bool isPasswordValid = _passwordHasherService.Verify(loginDto.Password, user.Password);

        if (!isPasswordValid)
            return Unauthorized("Password is incorrect");

        var token = _jwtService.GenerateToken(user);
        return Ok(new { token });
    }


    [HttpPatch("ChangePassword")]
    [Authorize]
    public async Task<ActionResult> Update([FromBody] UserLoginDTO updateDto)
    {
        var userEmailClaim = User.FindFirst(ClaimTypes.Email);
        if (userEmailClaim == null)
            return Unauthorized("Email claim not found.");
                  
        var userEmail = userEmailClaim.Value;
        var user = await _db.Users.FirstOrDefaultAsync(u => u.Email == userEmail);
        var userPassword = _passwordHasherService.Hash(updateDto.Password);

        updateDto.Password = userPassword;
        UserMapper.UpdateEntity(user, updateDto);
        await _db.SaveChangesAsync();

        return NoContent();
    }

    [HttpGet("All")]
    [Authorize]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<ActionResult<IEnumerable<UserDTO>>> GetUsers()
    {
        var userList = await _db.Users
        .Include(a => a.Department)
        .OrderBy(u => u.DepartmentId)
        .ThenBy(u => u.Role == "Manager" ? 0 : 1)
        .ThenBy(u => u.Name)
        .ToListAsync();
        var userDTOs = userList.Select(u => UserMapper.ToDTO(u, u.Department)).ToList();
        return Ok(userDTOs);
    }
}