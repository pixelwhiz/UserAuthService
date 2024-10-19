using Microsoft.EntityFrameworkCore;
using UserAuthService.dto;
using UserAuthService.entity;

namespace UserAuthService.Services;

public class AuthServiceHandler : IAuthService
{

    private readonly AppDbContext _dbContext;

    public AuthServiceHandler(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }
        
    public async Task<RegisterResponse> Register(RegisterDto registerDto)
    {
        var user = new Users
        {
            Username = registerDto.Username,
            Email = registerDto.Email,
            Password = registerDto.Password,
            CreatedAt = DateTime.UtcNow,
            UpdatedAt = DateTime.UtcNow
        };

        _dbContext.Add(user);
        await _dbContext.SaveChangesAsync();

        return new RegisterResponse
        {
            Id = user.Id,
            Username = user.Username,
            Email = user.Email,
            CreatedAt = user.CreatedAt,
            UpdatedAt = user.UpdatedAt
        };
    }
    
}