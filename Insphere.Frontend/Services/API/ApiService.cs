using Grpc.Core.Logging;
using Insphere.Frontend.Models;
using Insphere.Protos;
using Microsoft.Extensions.Logging;
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
        private readonly ILogger<IApiService> _logger;
        private readonly HttpClient _httpClient;
        public ApiService(ILogger<IApiService> logger, HttpClient httpClient) 
        { 
            _logger = logger;
            _httpClient = httpClient;
        }

        public async Task<PathDriftResponse> GetCoordinates(CancellationToken cancellationToken = default)
        {
            try
            {
                return await _httpClient.GetFromJsonAsync<PathDriftResponse>("/PathDrift/Data", cancellationToken) ?? new PathDriftResponse { Success = false, Message = "Unable to establish connection to the server." };
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, null);
                return new PathDriftResponse
                {
                    Success = false,
                    Message = ex.Message
                };
            }
        }
    }
}
