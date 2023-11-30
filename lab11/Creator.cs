using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab11
{
    class Creator
    {
        private static Dictionary<int, Building> buildingDictionary = new Dictionary<int, Building>();
        public static void CreateBuilding(int height, int floors, int apartments, int entrances)
        {
            Building building = new Building();
            building.Height = height;
            building.Floors = floors;
            building.Apartments = apartments;
            building.Entrances = entrances;
            buildingDictionary.Add(building.Number, building);
        }
        public static void RemoveBuilding(int number)
        {
            buildingDictionary.Remove(number);
        }
        public static void PrintBuildingInfo()
        {
            foreach (Building building in buildingDictionary.Values)
            {
                building.Info();
            }
        }
    }
}
