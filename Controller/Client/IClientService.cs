
namespace Contrat_AC.Controller.Client
{
    public interface IClientService
    {
        public Task<bool> CreateClient(Contrat_AC.Models.Client.Client client);
        public Task<Contrat_AC.Models.Client.Client?> EditClient(Contrat_AC.Models.Client.Client client);
        public Task<bool> DeleteClient(Contrat_AC.Models.Client.Client client);
        public Task<bool> UpdateClient(Contrat_AC.Models.Client.Client client);
        public Task<List<Contrat_AC.Models.Client.Client>> GetAllClient();
        public Task<Contrat_AC.Models.Client.Client?> GetClientById(long idClient);
        public Task<Contrat_AC.Models.Client.Client?> GetClientByNumCredit(string numCredit);

    }
}
