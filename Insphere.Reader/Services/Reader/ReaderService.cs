using Grpc.Core;
using Insphere.Protos;
using Insphere.Reader.Extensions;
using Insphere.Reader.Services.CsvReader;

namespace Insphere.Reader.Services.Reader
{
    public class ReaderService : Protos.Reader.ReaderBase
    {
        private readonly ILogger<ReaderService> _logger;
        private readonly ICsvReader _csvReader;
        public ReaderService(ILogger<ReaderService> logger, ICsvReader csvReader)
        {
            _logger = logger;
            _csvReader = csvReader;
        }
        public override async Task<PathDriftCoordinatesResponse> GetCoordinates(Google.Protobuf.WellKnownTypes.Empty request, ServerCallContext context)
        {
            var path = Path.Combine(Environment.CurrentDirectory, "Data", "run1.csv");
            var readResponse = await _csvReader.ReadDriftPathData(path, context.CancellationToken);
            if (!readResponse.Success)
                return new PathDriftCoordinatesResponse
                {
                    Success = false,
                    Message = readResponse.Message,
                };
            var response = new PathDriftCoordinatesResponse
            {
                Success = true,
            };
            var coordinates = readResponse.RawData
                .Select(data => data.ConvertToPathDriftCoordinate())
                .OfType<PathDriftCoordinate>()
                .ToList();
            response.Coordinates.AddToProtoList(coordinates);
            return response;
        }
    }
}
