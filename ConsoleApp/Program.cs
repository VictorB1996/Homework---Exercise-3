using System;
using System.Collections.Generic;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> planets = new List<string> { "Earth", "Mars", "Venus", "Saturn" };

            SolarSystem solarSystem = new SolarSystem(planets);

            //Console.WriteLine(String.Join(" ", solarSystem.Planets));

            //solarSystem.AddPlanet("Jupyter");

            //Console.WriteLine(String.Join(" ", solarSystem.Planets));

            //solarSystem.InsertPlanet("Jupyter", 1);

            //solarSystem.RemovePlanet("Earth");

            //solarSystem.ReplacePlanet("Pluto", 1);

            //solarSystem.SwapPlanets(1, 2);

            //solarSystem.ReversePlanets();

            //solarSystem.PrintPlanets();
        }
    }
}
