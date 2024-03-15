using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceTrack.RaceTrack.Cars
{
    public class Mazerati : RaceCar
    {
        public Mazerati()
        {
            Name = "Mazerati";
            TopSpeed = 120;
        }

        public override void StartEngine()
        {
            Console.WriteLine($"The {Name} purrs like a cougar!");
        }
        public override void Brake()
        {
            Console.WriteLine($"The {Name} screeches to a halt and the engine hisses!");
            base.Brake();
        }
    }
}