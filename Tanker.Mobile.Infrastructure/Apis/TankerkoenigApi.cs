using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Tanker.Mobile.Core.Interfaces.Data.Repositories;
using Tankerkoenig.Net;
using Tankerkoenig.Net.Models;
using Tankerkoenig.Net.Requests;
using Tankerkoenig.Net.Responses;
using Vessel;

namespace Tanker.Mobile.Infrastructure.Apis
{
    public class TankerkoenigApi
    {
        private readonly ISecureDataRepository _secureDataRepository;
        private TankerKoenig _tanker;

        public TankerkoenigApi(ISecureDataRepository secureDataRepository)
        {
            _secureDataRepository = secureDataRepository;
        }

        public async Task InitializeTankerkoenig()
        {
            _tanker = new TankerKoenig(await _secureDataRepository.GetTankerkoenigApiKey());
        }

        public async Task<Dto<List<Station>>> GetStations(SearchRequest searchRequest)
        {
            SearchResponse response = await _tanker.GetStationsAsync(searchRequest);

            string[] messages =
                {response.Message, response.ApiVersion, response.Timestamp.ToString(CultureInfo.InvariantCulture)};

            return (HttpStatusCode) response.Code != HttpStatusCode.OK
                ? Dto<List<Station>>.Success(response.Stations.ToList())
                : Dto<List<Station>>.Failed((HttpStatusCode) response.Code, messages);
        }
    }
}