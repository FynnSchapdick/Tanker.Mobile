using System.Threading.Tasks;

namespace Tanker.Mobile.Core.Interfaces.Data.Repositories
{
    public interface ISecureDataRepository
    {
        Task<string> GetTankerkoenigApiKey();
        Task SetGTankerkoenigApiKey(string value);
    }
}