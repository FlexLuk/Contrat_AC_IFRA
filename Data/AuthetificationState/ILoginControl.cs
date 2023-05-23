using Contrat_AC.Models.Autorisation;

namespace LYRA.Data
{
    public interface ILoginControl
    {
        public Task<User?> VerificationUtilisateur(string email, string passswordHash);
        public Task<List<Int32>> GetRoleIdUSer(User utilisateur);
        public Task<List<UsersRole>> GetRoleUserAuthentified(User utilisateur);
    }
}