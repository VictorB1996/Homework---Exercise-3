using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ConsoleApp
{
    class SolarSystem
    {
        public List<string> Planets { get; private set; }

        public SolarSystem(List<string> planets)
        {
            Planets = planets;
        }

        /// <summary>
        /// Adds Planet name at the end of the Planets list.
        /// </summary>
        /// <param name="name"></param>
        public void AddPlanet(string name)
        {
            string[] utilityArray = new string[Planets.Count + 1];
            for (int i = 0; i < Planets.Count; i++)
                utilityArray[i] = Planets[i];
            Planets = utilityArray.ToList();
            Planets[Planets.Count - 1] = name;
        }

        /// <summary>
        /// Insert Planet name at Index index in the Planets list
        /// </summary>
        /// <param name="name"></param>
        /// <param name="index"></param>
        public void InsertPlanet(string name, int index)
        {
            string[] utilityArray = new string[Planets.Count + 1];
            for(int i = 0; i < Planets.Count + 1; i++)
            {
                if (i < index)
                    utilityArray[i] = Planets[i];
                else if (i == index)
                    utilityArray[i] = name;
                else
                    utilityArray[i] = Planets[i - 1];
            }
            Planets = utilityArray.ToList();
        }

        /// <summary>
        /// Removes Planet name from the Planet List
        /// </summary>
        /// <param name="name"></param>
        public void RemovePlanet(string name)
        {
            string[] utilityArray = new string[Planets.Count];

            for(int i = 0; i < Planets.Count; i++)
            {
                if(Planets[i] != name)
                {
                    utilityArray[i] = Planets[i];
                }
            }
            Planets = utilityArray.ToList();
        }

        /// <summary>
        /// Replaces the Planet at Index index with newPlanet
        /// </summary>
        /// <param name="newPlanet"></param>
        /// <param name="index"></param>
        public void ReplacePlanet(string newPlanet, int index)
        {
            Planets[index] = newPlanet;
        }

        /// <summary>
        /// Swap Planets
        /// </summary>
        /// <param name="firstIndex"></param>
        /// <param name="secondIndex"></param>
        public void SwapPlanets(int firstIndex, int secondIndex)
        {
            string temporary = Planets[firstIndex];
            Planets[firstIndex] = Planets[secondIndex];
            Planets[secondIndex] = temporary;
        }

        /// <summary>
        /// Reverse the current order of the Planets List
        /// </summary>
        public void ReversePlanets()
        {
            string[] utilityArray = new string[Planets.Count];

            for(int i = 0; i < Planets.Count; i++)
            {
                utilityArray[i] = Planets[Planets.Count - i - 1];
            }

            Planets = utilityArray.ToList();
        }

        /// <summary>
        /// Prints all the Planets in the list
        /// </summary>
        public void PrintPlanets()
        {
            Console.WriteLine(String.Join(" ", Planets));
        }
    }
}
