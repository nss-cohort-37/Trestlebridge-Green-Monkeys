using System;
using System.Linq;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Animals;

namespace Trestlebridge.Actions
{
    public class ChooseDuckHouse
    {
        public static void CollectInput(Farm farm, IEggProducing animal)
        {
            Utils.Clear();

            Console.WriteLine($"Place the animal where?");

            while (true)
            {
                try
                {
                    static void duckHouseSelect(Farm farm, IEggProducing animal)
                    {
                        var filteredDuckHouses = farm.DuckHomes.Where(home => home.Capacity > home.AnimalCount).ToList();

                        if (filteredDuckHouses.Count() == 0)
                        {
                            Console.WriteLine("No houses are avaliable. Please add another house...");
                            Console.ReadLine();
                        }
                        else
                        {

                            for (int i = 0; i < filteredDuckHouses.Count(); i++)
                            {
                                Console.Write($"{i+1}. Duck House {filteredDuckHouses[i].ShortId} has {filteredDuckHouses[i].AnimalCount} ducks");

                                Console.WriteLine();
                            }

                            int choice = Int32.Parse(Console.ReadLine());
                            filteredDuckHouses[choice - 1].AddResource(animal);
                        }
                    }
                    duckHouseSelect(farm, animal);
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine($"Please make a valid selection! Press the return key...");
                    Console.ReadLine();
                }
            }

        }
    }
}