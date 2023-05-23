using Contrat_AC.Models.Autorisation;

namespace Contrat_AC.Controller.Autorisation
{
    public interface IAutorisationService
    {
        public Task<User?> GetValidUserCredentialAsync(string email, string password);
        public Task<string> GetUserRoleAsync(string email);
        public Task<List<UsersRole>> GetUserRoleListByUserAsync(int idUser);
        public Task<int> CreateUserAsync(User user);
        public Task<bool> CreateRoleAsync(Role role);
        public Task<bool> CreateUserRoleAsync(UsersRole userRole);
        public Task<User?> GetUserByIDAsync(int userID);
        public Task<List<Role>> GetAllRolesAsync(int userID);
        public Task<List<User>> GetAllUsersAsync();
    }
}
