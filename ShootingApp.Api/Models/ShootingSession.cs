using System;

namespace ShootingApp.Api.Models
{
    public class ShootingSession
    {
        // TO JEST TWÓJ BRAKUJĄCY KLUCZ GŁÓWNY:
        public int Id { get; set; }

        public DateTime Date { get; set; }
        public int ShotsTaken { get; set; }
        public int ShotsMade { get; set; }
    }
}