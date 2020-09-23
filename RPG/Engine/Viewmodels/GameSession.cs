using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;


namespace Engine.Viewmodels
{
    public class GameSession
    {
        public Engine.Models.player CurrentPlayer { get; set; }
        public Engine.Models.Location CurrentLocation {get; set;}

        public GameSession(){

            CurrentPlayer = new Engine.Models.player();
            CurrentPlayer.Name = "Slavi";
            CurrentPlayer.Gold = 1000000;
            CurrentPlayer.CharacterClass = "Fighter";
            CurrentPlayer.HitPoints = 10;
            CurrentPlayer.ExperiencePoints = 0;
            CurrentPlayer.Level = 1;

            CurrentLocation = new Location();
            CurrentLocation.Name = "Home";
            CurrentLocation.xCoordinate = 0;
            CurrentLocation.yCoordinate = -1;
            CurrentLocation.Description = "Home sweet home!";
            CurrentLocation.ImageName = "/Engine;component/Images/Locations/Home.png";

        }
    }
}
