using Grpc.Core;
using Insphere.Protos;
using Insphere.Reader.Extensions;
using Insphere.Reader.Services.CsvReader;

namespace Insphere.Reader.Services.Reader
{
    public class ReaderService : Protos.Reader.ReaderBase
    {
        private readonly ICsvReader _csvReader;
        public ReaderService(ICsvReader csvReader)
        {
            _csvReader = csvReader;
        }
        /// <summary>
        /// Read Drift Path CSV data, process it.
        /// </summary>
        /// <param name="request">Ignore this, it's for gRPC use only</param>
        /// <param name="context">Used for the cancellation token primarily</param>
        /// <returns>Response including centre point coordinates and list of points</returns>
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
            var centre = coordinates.CalculateCentrePoint();
            response.Coordinates.AddToProtoList(coordinates);
            response.AverageX = centre.AverageX;
            response.AverageY = centre.AverageY;
            response.AverageZ = centre.AverageZ;
            return response;
        }
    }
}
