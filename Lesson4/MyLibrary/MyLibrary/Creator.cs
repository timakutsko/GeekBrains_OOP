using System.Collections;

namespace MyLibrary
{
    public class Creator
    {
        private static Hashtable _buildingsHashTable = new Hashtable();

        private Creator()
        {
        }

        public static Building CreateBuild(int height, int levels, int flats, int entrances)
        {
            return new Building
            {
                Height = height,
                Levels = levels,
                Flats = flats,
                Entrances = entrances
            };
        }

        public static void BuildingsHashTable(Building build)
        {
            int number = build.GetHashCode();
            _buildingsHashTable.Add(number, build);
        }

        public static void DeleteBuilding(Building build)
        {
            int number = build.GetHashCode();
            _buildingsHashTable.Remove(number);
        }

    }
}
