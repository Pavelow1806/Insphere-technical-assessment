using Insphere.Reader.Models;

namespace Insphere.Reader.Services.CsvReader
{
    public class CsvReader : ICsvReader
    {
        /// <summary>
        /// Asynchronously processes Drift Path raw CSV data.
        /// </summary>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <returns>If it was successful or not, a message if not and the raw data if it was.</returns>
        public async Task<PathDriftRawDataResponse> ReadDriftPathData(string path, CancellationToken cancellationToken)
        {
            var lines = await File.ReadAllLinesAsync(path, cancellationToken);
            // Convert column numbers to property values
            var rawData = lines
                .Select(line => {
                    var items = line.Split(",");
                    return new PathDriftRawData
                    {
                        ID = items[(int)PathDriftRawDataColumn.ID],
                        Index = items[(int)PathDriftRawDataColumn.Index],
                        X = items[(int)PathDriftRawDataColumn.X],
                        Y = items[(int)PathDriftRawDataColumn.Y],
                        Z = items[(int)PathDriftRawDataColumn.Z],
                        Rx = items[(int)PathDriftRawDataColumn.Rx],
                        Ry = items[(int)PathDriftRawDataColumn.Ry],
                        Rz = items[(int)PathDriftRawDataColumn.Rz],
                        Ux = items[(int)PathDriftRawDataColumn.Ux],
                        Uy = items[(int)PathDriftRawDataColumn.Uy],
                        Uz = items[(int)PathDriftRawDataColumn.Uz],
                        UTranslation = items[(int)PathDriftRawDataColumn.UTranslation],
                        URx = items[(int)PathDriftRawDataColumn.URx],
                        URy = items[(int)PathDriftRawDataColumn.URy],
                        URz = items[(int)PathDriftRawDataColumn.URz],
                    };
                })
                .Skip(1) // Ignore the header row
                .ToList();
            if (rawData == null)
                return new PathDriftRawDataResponse
                {
                    Success = false,
                    Message = "Unable to process raw data."
                };
            return new PathDriftRawDataResponse
            {
                Success = true,
                RawData = rawData,
            };
        }
    }
}
