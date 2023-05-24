using Contrat_AC.Models.Autorisation;
using Microsoft.EntityFrameworkCore;

namespace Contrat_AC.AuthetificationState.Data
{
    public class LoginControl : ILoginControl
    {

        protected AUTORISATIONContext context;

        public LoginControl(AUTORISATIONContext _context)
        {
            context = _context;
        }

        public async Task<List<int>> GetRoleIdUSer(User utilisateur)
        {
            List<UsersRole> avRoles = new List<UsersRole>();
            avRoles = await context.UsersRoles.Where(x => x.UserId == utilisateur.UserId).ToListAsync();
            List<int> roleIDs = new List<int>();
            foreach (var item in avRoles)
            {
                roleIDs.Add(item.RoleId);
            }
            return roleIDs;
        }

        public async Task<List<Role>> GetRoleUserAuthentified(User utilisateur)
        {
            List<int> roleIDs = await GetRoleIdUSer(utilisateur);
            List<Role> roleNames = new List<Role>();
            foreach (var item in roleIDs)
            {
                Role? urole = new Role();
                urole = await context.Roles.Where(x => x.RoleId == item).FirstOrDefaultAsync();
                if (urole != null)
                    roleNames.Add(urole);
            }
            return roleNames;
        }

        public async Task<User?> VerificationUtilisateur(string email, string? passsword)
        {
            User? user = await context.Users.Where(x => x.AdressMail == email).FirstOrDefaultAsync();
            if (user != null && BCrypt.Net.BCrypt.Verify(passsword, user.PasswordHash))
                return user;
            else
                return null;
        }
    }
}