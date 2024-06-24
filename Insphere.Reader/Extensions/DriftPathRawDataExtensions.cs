using Insphere.Reader.Models;
using Insphere.Protos;
using Google.Protobuf.Collections;

namespace Insphere.Reader.Extensions
{
    public static class DriftPathRawDataExtensions
    {
        /// <summary>
        /// Validate Path Drift raw data.
        /// </summary>
        /// <param name="data">Path Drift raw data to be validated</param>
        /// <returns>Whether the raw data is in a valid format to be converted</returns>
        public static bool Validate(this PathDriftRawData data)
        {
            if (string.IsNullOrWhiteSpace(data.ID)) return false;
            if (string.IsNullOrWhiteSpace(data.Index) || !int.TryParse(data.Index, out _)) return false;
            if (string.IsNullOrWhiteSpace(data.X) || !double.TryParse(data.X, out _)) return false;
            if (string.IsNullOrWhiteSpace(data.Y) || !double.TryParse(data.Y, out _)) return false;
            if (string.IsNullOrWhiteSpace(data.Z) || !double.TryParse(data.Z, out _)) return false;
            if (string.IsNullOrWhiteSpace(data.Rx) || !double.TryParse(data.Rx, out _)) return false;
            if (string.IsNullOrWhiteSpace(data.Ry) || !double.TryParse(data.Ry, out _)) return false;
            if (string.IsNullOrWhiteSpace(data.Rz) || !double.TryParse(data.Rz, out _)) return false;
            if (string.IsNullOrWhiteSpace(data.Ux) || !double.TryParse(data.Ux, out _)) return false;
            if (string.IsNullOrWhiteSpace(data.Uy) || !double.TryParse(data.Uy, out _)) return false;
            if (string.IsNullOrWhiteSpace(data.Uz) || !double.TryParse(data.Uz, out _)) return false;
            if (string.IsNullOrWhiteSpace(data.UTranslation) || !double.TryParse(data.UTranslation, out _)) return false;
            if (string.IsNullOrWhiteSpace(data.URx) || !double.TryParse(data.URx, out _)) return false;
            if (string.IsNullOrWhiteSpace(data.URy) || !double.TryParse(data.URy, out _)) return false;
            if (string.IsNullOrWhiteSpace(data.URz) || !double.TryParse(data.URz, out _)) return false;
            return true;
        }
        /// <summary>
        /// Validate and convert Path Drift raw data to coordinate.
        /// </summary>
        /// <param name="data">Path Drift raw data point to be converted</param>
        /// <returns>Path drift coordinate</returns>
        public static PathDriftCoordinate? ConvertToPathDriftCoordinate(this PathDriftRawData data)
        {
            if (!data.Validate()) return null;
            return new PathDriftCoordinate
            {
                ID = data.ID,
                Index = int.Parse(data.Index),
                X = double.Parse(data.X),
                Y = double.Parse(data.Y),
                Z = double.Parse(data.Z),
                Rx = double.Parse(data.Rx),
                Ry = double.Parse(data.Ry),
                Rz = double.Parse(data.Rz),
                Ux = double.Parse(data.Ux),
                Uy = double.Parse(data.Uy),
                Uz = double.Parse(data.Uz),
                UTranslation = double.Parse(data.UTranslation),
                URx = double.Parse(data.URx),
                URy = double.Parse(data.URy),
                URz = double.Parse(data.URz),
            };
        }
        public static void AddToProtoList(this RepeatedField<PathDriftCoordinate> coordinates, List<PathDriftCoordinate> data) => 
            coordinates.AddRange(data);
    }
}
