using System;

namespace Geometry
{
    class Program
    {
        static void Main(string[] args)
        {
            Fegure fegure = new Fegure(Color.Black);
            fegure.ActualStatus();
            fegure.Move(10, 0);
            fegure.ChangeColor(Color.Red);
            fegure.ActualStatus();

            Point point = new Point(Color.White);


            
        }
    }
}
