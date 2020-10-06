using System;

namespace nsp
{
    public static class main
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                Vector2 v1 = new Vector2();
                v1.read();
                v1.setColor(new Color(255, 255, 0));
                Console.Write("v1 = ");
                v1.display();

                Vector2 v2 = new Vector2();
                v2.read();
                v2.setColor(new Color(0, 255, 255));
                Console.Write("v2 = ");
                v2.display();

                Console.WriteLine($"Angle between v1 and v2 = {v1.angle(v2)} degrees");

                Vector2 sum = v1.add(v2);
                Console.Write("v1 + v2 = ");
                sum.setColor(new Color(255, 0, 255));
                sum.display();

                Console.Write("\nPress any key to continue . . . ");
                Console.ReadKey();
                Console.Clear();
            }
        }

    }
}