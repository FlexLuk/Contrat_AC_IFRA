using Contrat_AC.Models.Client;
using Cliente = Contrat_AC.Models.Client.Client;
using Microsoft.AspNetCore.Connections;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Contracts;
using System.Net.Sockets;

namespace Contrat_AC.Controller.Client
{
    public class ClientService : IClientService
    {
        CLIENTContext context;

        public ClientService(CLIENTContext _context)
        {
            context = _context;
        }
        public async Task<Cliente?> CreateClient(Cliente client)
        {
            Cliente cli = client;
            await context.Clients.AddAsync(cli);
            context.SaveChanges();
            return cli;
        }

        public async Task<bool> DeleteClient(Cliente client)
        {
            try
            {
                context.Clients.Remove(client);
                int i = await context.SaveChangesAsync();
                return i > 0;
            }
            catch (InvalidOperationException)
            {
                return false;
            }
        }

        public async Task<Cliente?> EditClient(Cliente client)
        {
            context.Entry(client).State = EntityState.Modified;
            await context.SaveChangesAsync();
            return client;
        }

        public async Task<List<Cliente>> GetAllClient()
        {
            List<Cliente> client;
            client = await context.Clients.ToListAsync<Cliente>();
            context.SaveChanges();
            return client;
        }

        public async Task<Cliente?> GetClientById(long idClient)
        {
            Cliente cli = new();
            try
            {
                cli = await context.Clients.Where(c => c.Clientid == idClient).FirstAsync<Cliente>();
                context.SaveChanges();
                return cli;
            }
            catch (InvalidOperationException)
            {
                return cli;
            }
        }

        public Task<Cliente?> GetClientByNumCredit(string numCredit)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> UpdateClient(Cliente client)
        {
            context.Entry(client).State = EntityState.Modified;
            int i = await context.SaveChangesAsync();
            return i > 0;
        }
    }
}
