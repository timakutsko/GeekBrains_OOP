namespace Geometry
{
    class Program
    {
        static void Main(string[] args)
        {
            Point point = new Point(Color.Black);
            point.ActualStatus();
            
            point.Move(10, 23);
            point.ChangeColor(Color.Red);
            point.Hide = true;
            point.ActualStatus();

            Circle circle = new Circle(Color.Red, 12);
            circle.ActualStatus();
            circle.Move(20, 20);
            circle.Hide = true;
            circle.ActualStatus();

            Rectangle rectangle = new Rectangle(Color.White, 10, 20);
            rectangle.ActualStatus();
            rectangle.Move(50, 40);
            rectangle.ChangeColor(Color.Red);
            rectangle.ActualStatus();
            
        }
    }
}
