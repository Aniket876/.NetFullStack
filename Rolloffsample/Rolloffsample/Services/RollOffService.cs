using Rolloffsample.Helpers;
using Rolloffsample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Rolloffsample.Services
{
    public class RollOffService:IRollOffService
    {
        private readonly HttpClient _client;
        public const string BasePath = "/RollOff";
        public RollOffService(HttpClient client)
        {
            _client = client ?? throw new ArgumentNullException(nameof(client));
        }

        public async Task<IEnumerable<RollOffTable>> Find()
        {
                var response = await _client.GetAsync(BasePath);

                return await response.ReadContentAsync<List<RollOffTable>>();
        }

        public async Task<RollOffTable> SearchbyGGid(double ggid)
        {
            string path = $"/RollOff/{ggid}";
            var response = await _client.GetAsync(path);
            return await response.ReadContentAsync<RollOffTable>();
        }
    }
}
