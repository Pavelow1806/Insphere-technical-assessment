using Insphere.Frontend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insphere.Frontend.Services.API
{
    public interface IApiService
    {
        Task<PathDriftResponse> GetCoordinates(CancellationToken cancellationToken = default);
    }
}
