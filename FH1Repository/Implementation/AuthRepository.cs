using FH1Repository.Interface;
using FH1Repository.Models;
using Microsoft.EntityFrameworkCore;

namespace FH1Repository.Implementation;

public class AuthRepository(DemoProjContext context) : IAuthRepository
{
    private readonly DemoProjContext _context = context;
    public async Task<User?> GetByEmail(string email)
    {
        return await _context.Users
        .FirstOrDefaultAsync(user => user.Email.ToLower() == email.ToLower());
    }

}
