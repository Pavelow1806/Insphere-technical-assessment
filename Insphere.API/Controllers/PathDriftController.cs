using Grpc.Core;
using Grpc.Net.Client;
using Insphere.Global.Configuration;
using Insphere.Protos;
using Microsoft.AspNetCore.Mvc;

namespace Insphere.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PathDriftController : ControllerBase
    {
        private readonly ILogger<PathDriftController> _logger;

        public PathDriftController(ILogger<PathDriftController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("Data")]
        public async Task<PathDriftCoordinatesResponse> Data(CancellationToken cancellationToken)
        {
            using (var channel = GrpcChannel.ForAddress(AddressConfiguration.Reader))
            {
                var client = new Reader.ReaderClient(channel);
                var options = new CallOptions(cancellationToken: cancellationToken);
                var response = client.GetCoordinates(new Google.Protobuf.WellKnownTypes.Empty(), options);
                return response;
            }
        }
    }
}
