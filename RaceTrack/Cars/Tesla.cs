using System;
namespace RaceTrack.RaceTrack.Cars
{
    public class Tesla : RaceCar
    {
        public Tesla()
        {
            Name = "Tesla";
            TopSpeed = 125;
        }

        public override void StartEngine()
        {
            Console.WriteLine($"The {Name} revs their engine!");
        }

    }
    }

