using Insphere.Frontend.Models;
using Insphere.Protos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace Insphere.Frontend.Services.API
{
    public class ApiService : IApiService
    {
        private readonly HttpClient _httpClient;
        public ApiService(HttpClient httpClient) 
        { 
            _httpClient = httpClient;
        }

        public async Task<PathDriftResponse> GetCoordinates(CancellationToken cancellationToken = default)
        {
            return await _httpClient.GetFromJsonAsync<PathDriftResponse>("/PathDrift/Data", cancellationToken) ?? new PathDriftResponse { Success = false, Message = "Unable to establish connection to the server." };
        }
    }
}
