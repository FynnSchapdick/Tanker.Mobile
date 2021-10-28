using System;
using System.Threading.Tasks;
using Tanker.Mobile.Core.Interfaces.Data.Repositories;
using Xamarin.Essentials;

namespace Tanker.Mobile.Infrastructure.Data.Repositories
{
    public class SecureDataRepository : ISecureDataRepository
    {
        private const string TankerkoenigApiKey = "tankerkoenig_api_key";
        
        public Task<string> GetTankerkoenigApiKey()
        {
            return GetSecureStorageValue(TankerkoenigApiKey);
        }
        
        public Task SetGTankerkoenigApiKey(string value)
        {
            return SetSecureStorageValue(TankerkoenigApiKey, value);
        }
        
        private static bool RemoveSecureStorageValue(string key)
        {
            try
            {
                return SecureStorage.Remove(key);
            }
            catch (Exception)
            {
                // Possible that device doesn't support secure storage on device.
                return false;
            }
        }
        
        private static async Task SetSecureStorageValue(string key, string value)
        {
            try
            {
                await SecureStorage.SetAsync(key, value);
            }
            catch (Exception)
            {
                // Possible that device doesn't support secure storage on device.
            }
        }
        
        private static Task<string> GetSecureStorageValue(string key)
        {
            try
            {
                return SecureStorage.GetAsync(key);
            }
            catch (Exception)
            {
                // Possible that device doesn't support secure storage on device.
            }

            return null;
        }

    }
}