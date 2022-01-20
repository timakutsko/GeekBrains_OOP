using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    enum Color
    {
        White,
        Red,
        Black
    }
    internal class Fegure
    {
        private Color _color;
        private static bool _hide;
        private int _x = 0;
        private int _y = 0;

        public Fegure(Color col)
        {
            _color = col;
            _hide = false;
        }

        public Color Color 
        { 
            get => _color; 
            set => _color = value; 
        }

        public bool Hide
        {
            get => _hide;
            set => _hide = value;
        }

        public void Move(int x, int y)
        {
            _x = x;
            _y = y;
        }

        public void ChangeColor(Color newColor)
        {
            _color = newColor;
        }

        public string IsHiden()
        {
            if (_hide)
            {
                return "Скрыт";
            }
            else
            {
                return "Виден";
            }
        }

        public void ActualStatus()
        {
            Console.WriteLine($"Цвет: {_color};\nВидимость: {this.IsHiden()};\nКоординаты: X - {_x}, Y - {_y}");
            Console.WriteLine(new string('\u2550', Console.WindowWidth));
        }
        
    }
}
