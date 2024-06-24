using Insphere.Frontend.Extensions;
using Insphere.Frontend.Models;
using Insphere.Frontend.Services.API;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insphere.Frontend.ViewModels
{
    public class PathDriftViewModel : IPathDriftViewModel, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string name) => this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));

        private List<PathDriftModel> models = new List<PathDriftModel>();
        public ObservableCollection<PathDriftModel> Models
        {
            get => new ObservableCollection<PathDriftModel>(models);
            set
            {
                if (models.Count() != value.Count())
                {
                    models = value.ToList();
                    OnPropertyChanged(nameof(Models));
                }
            }
        }

        private string status = "";
        public string Status
        {
            get => status;
            set
            {
                if (status != value)
                {
                    status = value;
                    OnPropertyChanged(nameof(Status));
                }
            }
        }

        private readonly IApiService _apiService;
        public PathDriftViewModel(IApiService apiService) 
        { 
            _apiService = apiService;
            RequestData();
        }

        public async void RequestData()
        {
            Status = "Data requested...";
            var response = await _apiService.GetCoordinates(new CancellationToken());
            Status = "Processing response...";
            if (response == null)
            {
                Status = "Unable to establish connection to server.";
            }
            else
            {
                if (response.Success)
                {
                    Models = new ObservableCollection<PathDriftModel>(response.Coordinates
                        .Select(coordinate => coordinate.ConvertToModel())
                        .ToList());
                    Status = $"Displaying {Models.Count()} models in current view.";
                }
                else
                {
                    Status = response.Message;
                }
            }
        }
    }
}
