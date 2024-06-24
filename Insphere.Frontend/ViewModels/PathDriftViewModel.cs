using HelixToolkit.Wpf;
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
using System.Windows.Media.Media3D;

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
        public HelixViewport3D Viewport { get; set; }
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
                    // Display table view data
                    Models = new ObservableCollection<PathDriftModel>(response.Coordinates
                        .Select(coordinate => coordinate.ConvertToModel())
                        .ToList());
                    // Clear existing 3d viewport children and render new view
                    Viewport.Children.Clear();
                    var linesVisual = new LinesVisual3D();
                    for (int i = 0; i < models.Count() - 1; i++)
                    {
                        var currentModel = models[i];
                        var nextModel = models[i + 1];
                        linesVisual.Points.Add(currentModel.ToPoint3D());
                        linesVisual.Points.Add(nextModel.ToPoint3D());
                    }
                    Viewport.Children.Add(linesVisual);
                    Viewport.CameraController.CameraTarget = new Point3D(response.AverageX, response.AverageY, response.AverageZ);
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
