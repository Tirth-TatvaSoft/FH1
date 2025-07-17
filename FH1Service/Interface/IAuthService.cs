using FH1Core.RequestModels;
using FH1Core.ResponseModels;

namespace FH1Service.Interface;

public interface IAuthService
{
    Task<ServiceResult<AuthResponse>> Login(AuthRequest request);

}
