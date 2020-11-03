using System;

namespace nsp
{
    public static class main
    {
        public static void Main(string[] args)
        {
            Random rnd = new Random(DateTime.Now.Millisecond);
            int k = 10;
            Vector2[] arr = new Vector2[k];
            for (int i = 0; i < k; i++)
            {
                byte[] color = new byte[3];
                rnd.NextBytes(color);
                arr[i] = new Vector2(
                    rnd.NextDouble()*Int16.MaxValue,
                    rnd.NextDouble()*Int16.MaxValue,
                    new Color(color[0], color[1], color[2])
                );
            }

            for (int i = 0; i < k; i++)
            {
                Console.WriteLine(arr[i]);
            }

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