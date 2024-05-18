using day24WebApp.models;

namespace day24WebApp.interfaces
{
    public interface ITokenService
    {
        public string GenerateToken(Employee employee);
    }
}
