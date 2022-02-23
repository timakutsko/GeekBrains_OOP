namespace Geometry
{
    internal sealed class Circle : Point
    {
        private int _diameter = 0;

        public Circle(Color col, int diam) : base(col)
        {
            _diameter = diam;
        }

        public override int Square() => _diameter * _diameter;
    }
}
