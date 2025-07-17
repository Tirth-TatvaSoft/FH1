using FH1Core;
using FH1Core.RequestModels;
using FH1Core.ResponseModels;
using FH1Repository.Interface;
using FH1Repository.Models;
using FH1Service.Interface;

namespace FH1Service.Implementation;

public class AuthService(IAuthRepository authRepository, IRepository<User> userRepo) : IAuthService
{
    private readonly IRepository<User> _userRepo = userRepo;
    private readonly IAuthRepository _authRepo = authRepository;
    public async Task<ServiceResult<AuthResponse>> Login(AuthRequest request)
    {
        User? user = await _authRepo.GetByEmail(request.Email.Trim());
        if (user == null || !user.Isactive)
        {
            return ServiceResult<AuthResponse>.Failure(Constants.USER_NOT_EXIST);
        }
        if (!BCrypt.Net.BCrypt.Verify(request.Password.Trim(), user.HashPassword))
        {
            return ServiceResult<AuthResponse>.Failure(Constants.INVALID_CREDENTIALS);
        }
        // string token = _jwtService.GenerateToken(user);
        AuthResponse response = new ()
        {
            // Token = token,
            // UserId = user.Id.ToString(),
            // Email = user.Email,
            // Roles = user.Role
        };
        return ServiceResult<AuthResponse>.SuccessResult(response);
    }

}
