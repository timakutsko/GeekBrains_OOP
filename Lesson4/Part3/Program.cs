using System;
using MyLibrary;

namespace Part3
{
    class Program
    {
        static void Main(string[] args)
        {

            Building building1 = Creator.CreateBuild(111, 30, 289, 3);
            Building building2 = Creator.CreateBuild(106, 22, 200, 5);
            Building building3 = Creator.CreateBuild(106, 22, 200, 5);

            Creator.BuildingsHashTable(building1);
            Creator.BuildingsHashTable(building2);
            Creator.BuildingsHashTable(building3);

            Creator.DeleteBuilding(building2);
        }
    }
}
