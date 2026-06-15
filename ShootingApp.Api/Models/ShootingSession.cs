using System;

namespace ShootingApp.Api.Models
{
    public class ShootingSession
    {
        public int Id { get; set; }

        public DateTime Date { get; set; }
        public int ShotsTaken { get; set; }
        public int ShotsMade { get; set; }
    }
}