using RaceTrack.RaceTrack.Cars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceTrack.RaceTrack.Drivers
{
    public class SkinDiesel : Driver
    {
        public SkinDiesel(RaceCar car) : base(car) 
        {
            Name = "Skin Diesel";
            SkillLevel = 11;
        }

        public override void Drive()
        {
            Car.Accelerate(SkillLevel);
        }
    }
}
