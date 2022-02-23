using System;

namespace MyLibrary
{
    public class Building
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
            if (restValue != 0)
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
