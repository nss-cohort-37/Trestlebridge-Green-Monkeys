using System;
using System.Collections.Generic;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Animals;
using Trestlebridge.Models.Facilities;
using Trestlebridge.Models.Plants;

namespace Trestlebridge.Actions {
    public class PurchaseStock {
        public static void CollectInput (Farm farm) {
            var animalList = new List<IResource> ();
            animalList.Add (new Chicken ());
            animalList.Add (new Cow ());
            animalList.Add (new Duck ());
            animalList.Add (new Goat ());
            animalList.Add (new Ostrich ());
            animalList.Add (new Pig ());
            animalList.Add (new Sheep ());

            foreach (var animal in animalList) {
                var animalIndex = animalList.IndexOf (animal) + 1;
                Console.WriteLine ($"{animalIndex}. {animal}");
            }

            Console.WriteLine ();
            Console.WriteLine ("What are you buying today?");

            Console.Write ("> ");
            string choice = Console.ReadLine ();

            switch (Int32.Parse (choice)) {
                case 1:

                    ChooseChickenHouse.CollectInput (farm, new Chicken ());
                    break;
                case 2:
                    ChooseGrazingField.CollectInput (farm, new Cow ());
                    break;
                case 3:
                    ChooseDuckHouse.CollectInput (farm, new Duck ());
                    break;
                case 4:
                    ChooseGrazingField.CollectInput (farm, new Goat ());
                    break;
                case 5:
                    ChooseGrazingField.CollectInput (farm, new Ostrich ());
                    break;
                case 6:
                    ChooseGrazingField.CollectInput (farm, new Pig ());
                    break;
                case 7:
                    ChooseGrazingField.CollectInput (farm, new Sheep ());
                    break;
                default:
                    break;
            }
        }
    }
}