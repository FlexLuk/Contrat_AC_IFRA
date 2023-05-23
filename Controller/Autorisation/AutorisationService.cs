﻿using Contrat_AC.Models.Autorisation;
using Microsoft.AspNetCore.Connections;
using Microsoft.EntityFrameworkCore;

namespace Contrat_AC.Controller.Autorisation
{
    public class AutorisationService : IAutorisationService
    {
        AUTORISATIONContext context;
        public AutorisationService()
        {
            context = new AUTORISATIONContext();
        }

        public async Task<bool> CreateRoleAsync(Role role)
        {
            await context.Roles.AddAsync(role);
            int i = context.SaveChanges();
            return i > 0;
        }

        public async Task<int> CreateUserAsync(User user)
        {
            EncryptionandDecryption cryptage = new();
            user.Password = cryptage.Encrypt(user.Password);
            await context.Users.AddAsync(user);
            int i = context.SaveChanges();
            return user.UserId;
        }

        public async Task<bool> CreateUserRoleAsync(UsersRole userRole)
        {
            await context.UsersRoles.AddAsync(userRole);
            int i = context.SaveChanges();
            return i > 0;
        }

        public async Task<List<Role>> GetAllRolesAsync(int userID)
        {
            List<Role> cont = new();
            cont = await context.Roles.ToListAsync();
            context.SaveChanges();
            return cont;
        }

        public async Task<List<User>> GetAllUsersAsync()
        {
            List<User> users = new();
            users = await context.Users.ToListAsync();
            context.SaveChanges();
            return users;
        }

        public async Task<User?> GetUserByIDAsync(int userID)
        {
            User? us = new();
            us = await context.Users.Where(u => u.UserId == userID).FirstOrDefaultAsync();
            context.SaveChanges();
            return us;
        }

        public async Task<User?> GetUserByEmailAsync(string email)
        {
            User? us = new();
            try
            {
                us = await context.Users.Where(u => u.AdressMail == email).FirstAsync();
                context.SaveChanges();
                return us;
            }
            catch (InvalidOperationException)
            {
                return us = null;
            }
        }

        public async Task<string> GetUserRoleAsync(string email)
        {
            User? us = new();
            UsersRole? uRl = new();
            Role? rl = new();
            us = await context.Users.Where(u => u.AdressMail == email).FirstOrDefaultAsync();
            context.SaveChanges();
            uRl = await context.UsersRoles.Where(u => u.UserId == us.UserId).FirstOrDefaultAsync();
            context.SaveChanges();
            rl = await context.Roles.Where(u => u.RoleId == uRl.RoleId).FirstOrDefaultAsync();
            context.SaveChanges();
            return rl.RoleName;
        }

        public async Task<User?> GetValidUserCredentialAsync(string email, string password)
        {
            User? user = new();
            EncryptionandDecryption cryptage = new();
            user = await GetUserByEmailAsync(email);

            if (user != null)
            {
                string _passwrd = cryptage.Decrypt(user.Password);
                if (password == _passwrd)
                {
                    return user;
                }
                else
                {
                    return null;
                }
            }
            else
            {
                return null;
            }

        }

        public async Task<List<UsersRole>> GetUserRoleListByUserAsync(int idUser)
        {
            List<UsersRole>? usRole = new List<UsersRole>();
            usRole = await context.UsersRoles.Where(u => u.UserId == idUser).ToListAsync();
            context.SaveChanges();
            return usRole;
        }
    }
}