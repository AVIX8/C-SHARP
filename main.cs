using System;
using System.Linq;

namespace nsp
{
    public static class main
    {
        public static void Pause() {
            Console.Write("\nPress any key to continue . . . ");
            Console.ReadKey();
            Console.Clear();
        }

        private static readonly Random rnd = new Random(DateTime.Now.Millisecond);

        public static void Main(string[] args)
        {
            Console.WriteLine("3) Инициализировать небольшой массив конструктором с одним параметром;");

            Vector2[] arr = new Vector2[3] { new Vector2(), new Vector2(2, 4), new Vector2(3, 6, Color.red) };

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

            Pause();

            Console.WriteLine("LR_11. 1) В main продемонстрировать работу с одно и двумерными массивами объектов вашего класса;");

            Vector2[,] twoDimArr = new Vector2[10,30];
            for (int i = 0; i < twoDimArr.GetLength(0); i++) {
                for (int j = 0; j < twoDimArr.GetLength(1); j++) {
                    twoDimArr[i,j] = new Vector2(i,j,
                        new Color(i*(int)255/twoDimArr.GetLength(0), 0, j*(int)255/twoDimArr.GetLength(1))
                    );
                }
            }

            for (int i = 0; i < twoDimArr.GetLength(0); i++) {
                for (int j = 0; j < twoDimArr.GetLength(1); j++) {
                    Console.Write(twoDimArr[i,j].color);
                }
                Console.WriteLine();
            }

            Pause();

            while (true)
            {
                Vector2 v1 = new Vector2();
                v1.read();
                v1.setColor(Color.red);
                Console.Write("v1 = ");
                v1.display();

                Vector2 v2 = new Vector2();
                v2.read();
                v2.setColor(Color.green);
                Console.Write("v2 = ");
                v2.display();

                Console.WriteLine($"Angle between v1 and v2 = {Vector2.angle(v1, v2)} degrees");

                Vector2 sum = v1 + v2;
                Console.Write("v1 + v2 = ");
                sum.setColor(Color.blue);
                sum.display();

                Pause();
            }
        }

        static void initRandom(out Vector2 a) {
            byte[] color = new byte[3];
            rnd.NextBytes(color);
            a = new Vector2(
                rnd.NextDouble()*Int16.MaxValue,
                rnd.NextDouble()*Int16.MaxValue,
                new Color(color[0], color[1], color[2])
            );
        }

        static void normalize(ref Vector2 a) {
            double len = a.length;
            a.x /= len;
            a.y /= len;
        }

    }
}