using System.Collections.Generic;
using System.Threading.Tasks;
using Tankerkoenig.Net.Models;
using Tankerkoenig.Net.Requests;
using Vessel;

namespace Tanker.Mobile.Core.Interfaces.Apis
{
    public interface ITankerkoenigApi
    {
        Task InitializeTankerkoenig();
        Task<Dto<List<Station>>> GetStations(SearchRequest searchRequest);
    }
}