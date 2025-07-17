
using FH1Repository.Models;

namespace FH1Repository.Interface;

public interface IAuthRepository
{
    Task<User?> GetByEmail(string email);

}
