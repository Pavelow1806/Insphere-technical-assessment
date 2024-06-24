using Insphere.Frontend.Services.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insphere.Frontend.ViewModels
{
    public class PathDriftViewModel : IPathDriftViewModel
    {
        private readonly IApiService _apiService;
        public PathDriftViewModel(IApiService apiService) 
        { 
            _apiService = apiService;
        }
    }
}
