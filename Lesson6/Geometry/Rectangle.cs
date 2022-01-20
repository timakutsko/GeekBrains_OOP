namespace Geometry
{
    internal sealed class Rectangle : Point
    {
        private int _height;
        private int _width;

        public Rectangle(Color col, int h, int w) : base(col)
        {
            _height = h;
            _width = w;
        }

        public override int Square() => _height * _width;
    }
}
