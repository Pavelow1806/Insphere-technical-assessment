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
        public PathDriftCoordinatesResponse Data(CancellationToken cancellationToken)
        {
            try
            {
                // Use gRPC to get coordinate data from the Reader service
                using (var channel = GrpcChannel.ForAddress(AddressConfiguration.Reader))
                {
                    var client = new Reader.ReaderClient(channel);
                    var options = new CallOptions(cancellationToken: cancellationToken);
                    var response = client.GetCoordinates(new Google.Protobuf.WellKnownTypes.Empty(), options);
                    return response;
                }
            }
            catch (Exception ex) 
            {
                _logger.LogError(ex, null);
                return new PathDriftCoordinatesResponse
                {
                    Success = false,
                    Message = "Unable to reach the Reader service, ensure the service is running and please try again."
                };
            }
        }
    }
}
