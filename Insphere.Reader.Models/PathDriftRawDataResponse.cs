using Insphere.Global.Models;

namespace Insphere.Reader.Models
{
    public class PathDriftRawDataResponse : ResponseBase
    {
        public List<PathDriftRawData> RawData { get; set; } = new List<PathDriftRawData>();
    }
}
