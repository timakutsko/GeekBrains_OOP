namespace Geometry
{
    internal class Point : Fegure
    {
        public Point(Color col)
        {
            _color = col;
            _hide = false;
        }

        public override int Square() => 1;
    }
}
