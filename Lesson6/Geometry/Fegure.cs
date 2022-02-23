using System;

namespace Geometry
{
    enum Color
    {
        White,
        Red,
        Black
    }
    internal abstract class Fegure
    {
        protected Color _color;
        protected bool _hide;
        protected int _x = 0;
        protected int _y = 0;

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
            Console.WriteLine(GetType().Name);
            Console.WriteLine($"Цвет: {_color};\nВидимость: {this.IsHiden()};\nКоординаты: X - {_x}, Y - {_y};\nПлощадь: {Square()}");
            Console.WriteLine(new string('\u2550', Console.WindowWidth));
        }

        public abstract int Square();

    }
}
