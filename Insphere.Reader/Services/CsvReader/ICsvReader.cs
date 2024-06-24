using Insphere.Reader.Models;

namespace Insphere.Reader.Services.CsvReader
{
    public interface ICsvReader
    {
        /// <summary>
        /// Asynchronously processes Drift Path raw CSV data.
        /// </summary>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <returns>If it was successful or not, a message if not and the raw data if it was.</returns>
        Task<PathDriftRawDataResponse> ReadDriftPathData(string path, CancellationToken cancellationToken);
    }
}
