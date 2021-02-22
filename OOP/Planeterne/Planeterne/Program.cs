using System;
using System.Collections.Generic;

namespace Planeterne
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Planet> planets = new List<Planet>();
            //                      Name        Mass        Diameter    Density     Gravity     Rotation    LengthDay   Distance    OrbitralP   OrbitalV    Temp        Moons   RingSystem
            planets.Add(new Planet("Mercury",   0.330,      4879,       5427,       3.7,        1407.6,     4222.6,     57.9,       88.0,       47.4,       167,        0,      false));
            planets.Add(new Planet("Venus",     4.87,       12104,      5243,       8.9,        -5832.5,    2802.0,     108.2,      224.7,      35.0,       464,        0,      false));
            planets.Add(new Planet("Earth",     5.97,       12756,      5514,       9.8,        23.9,       24.0,       149.6,      365.2,      29.8,       15,         1,      false));
            planets.Add(new Planet("Mars",      0.642,      6792,       3933,       3.7,        24.6,       24.7,       227.9,      687.0,      24.1,       -65,        2,      false));
            planets.Add(new Planet("Jupiter",   1898,       142984,     1326,       9.9,        1407.6,     9.9,        778.6,      4331,       13.1,       -110,       67,     true));
            planets.Add(new Planet("Saturn",    568,        120536,     687,        9.0,        10.7,       10.7,       1433.5,     10747,      9.7,        -140,       62,     true));
            planets.Add(new Planet("Uranus",    86.8,       51118,      1271,       8.7,        -17.2,      17.2,       2872.5,     30589,      6.8,        -195,       27,     true));
            planets.Add(new Planet("Neptune",   102,        49528,      1638,       11.0,       16.1,       16.1,       4495.1,     59.8,       5.4,        -200,       14,     true));
            planets.Add(new Planet("Pluto",     0.0146,     2370,       2095,       0.7,        -153.3,     153.3,      5906.4,     90.56,      4.7,        -225,       5,      false));
            
            //Output planets
            foreach(Planet planet in planets)
            {
                Console.Write("----------{");
                Console.Write(planet.Name);
                Console.WriteLine("}----------");
                Console.WriteLine("Mass (1024kg): {0}", planet.Mass);
                Console.WriteLine("Diameter (km): {0}", planet.Diameter);
                Console.WriteLine("Density (kg/m3): {0}", planet.Density);
                Console.WriteLine("Gravity (m/s2): {0}", planet.Gravity);
                Console.WriteLine("Rotation Period (hours): {0}", planet.RotationPeriod);
                Console.WriteLine("Length of Day (hours): {0}", planet.LengthOfDays);
                Console.WriteLine("Orbital Period (days): {0}", planet.OrbitalPeriod);
                Console.WriteLine("Orbital Velocity (km/s): {0}", planet.OrbitalVelocity);
                Console.WriteLine("Mean Temperature (C): {0}", planet.MeanTemperature);
                Console.WriteLine("Number of Moons: {0}", planet.NumberOfMoons);
                Console.WriteLine("Ring System?: {0}\n", planet.RingSystem);
            }

            Console.ReadKey();
        }
    }
}
