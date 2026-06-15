using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Net.Http.Json;
using ShootingApp.Client.Models; // Upewnij się, że masz folder Models z klasą ShootingSession

namespace ShootingApp.Client.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        private int _shotsTaken;

        [ObservableProperty]
        private int _shotsMade;

        private readonly HttpClient _httpClient = new()
        {
            BaseAddress = new Uri("https://localhost:7288/")
        };

        [RelayCommand]
        private void AddMake()
        {
            ShotsTaken++; 
            ShotsMade++;  
        }

        [RelayCommand]
        private void AddMiss()
        {
            ShotsTaken++; 
        }

        [RelayCommand]
        private async Task SaveToDatabase()
        {
            var session = new ShootingSession
            {
                Date = DateTime.UtcNow,
                ShotsTaken = ShotsTaken, 
                ShotsMade = ShotsMade    
            };

            await _httpClient.PostAsJsonAsync("api/shootingsessions", session);

            ShotsTaken = 0; 
            ShotsMade = 0;  
        }
    }
}