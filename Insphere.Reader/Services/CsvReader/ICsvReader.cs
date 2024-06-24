using Insphere.Reader.Models;

namespace Insphere.Reader.Services.CsvReader
{
    public interface ICsvReader
    {
        Task<PathDriftRawDataResponse> ReadDriftPathData(string path, CancellationToken cancellationToken);
    }
}
