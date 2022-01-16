using System;
using System.Collections;

namespace Building
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
            
            /*
            Building building1 = new Building
            {
                Height = 111,
                Levels = 30,
                Flats = 289,
                Entrances = 3
            };
            Building building2 = new Building
            {
                Height = 106,
                Levels = 22,
                Flats = 200,
                Entrances = 5
            };
            Building building3 = new Building
            {
                Height = 109,
                Levels = 22,
                Flats = 280,
                Entrances = 20
            };
            
            Console.WriteLine($"Номер дома: {building1.Number}");
            building1.LevelHeight();
            building1.FlatsInEntrances();
            building1.FlatsOnLevel();
            Console.WriteLine("________________________________");

            Console.WriteLine($"Номер дома: {building2.Number}");
            building2.LevelHeight();
            building2.FlatsInEntrances();
            building2.FlatsOnLevel();
            Console.WriteLine("________________________________");
            
            Console.WriteLine($"Номер дома: {building3.Number}");
            building3.LevelHeight();
            building3.FlatsInEntrances();
            building3.FlatsOnLevel();
            Console.WriteLine("________________________________");
            */
        }
    }

    sealed class Building
    {
        private static int _prevNumber = 0;
        private readonly int _number;
        private int _height;
        private int _levels;
        private int _flats;
        private int _entrances;
        private int[] _flatsInEntr;

        public Building()
        {
            _number = _prevNumber + 1;
            _prevNumber = _number;
        }
        
        public int Number
        {
            get
            {
                return _number;
            }
        }

        public int Height
        {
            get
            {
                return _height;
            }
            set
            {
                _height = value;
            }
        }

        public int Levels
        {
            get
            {
                return _levels;
            }
            set
            {
                _levels = value;
            }
        }

        public int Flats
        {
            get
            {
                return _flats;
            }
            set
            {
                _flats = value;
            }
        }

        public int Entrances
        {
            get
            {
                return _entrances;
            }
            set
            {
                _entrances = value;
            }
        }

        public void LevelHeight()
        {
            float levHeight = (_height / (float)_levels);
            Console.WriteLine($"Высота этажа: {levHeight:0.00}");
        }

        public void FlatsInEntrances()
        {
            int integerValue = _flats / _entrances;
            int restValue = _flats % _entrances;
            _flatsInEntr = new int[2];
            _flatsInEntr[0] = integerValue;
            _flatsInEntr[1] = _flats - integerValue * (_entrances - 1);
            if(restValue != 0)
            {
                Console.WriteLine($"В {_entrances - 1} подъездах - {_flatsInEntr[0]} квартир, а в последнем - {_flatsInEntr[1]} квартир");
            }
            else
            {
                Console.WriteLine($"В {_entrances} подъездах - {_flatsInEntr[0]} квартир");
            }
        }

        public void FlatsOnLevel()
        {
            float integerValue = _flats / (float)_levels / (float)_entrances;
            Console.WriteLine($"В среднем - по {integerValue:0.00} на этаж");
        }
    }
}
