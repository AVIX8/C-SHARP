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
            Console.WriteLine("Массив объектов:");

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

            Pause();

            Console.Write("out (инициализация случайного вектора): \n\t");
            Vector2 vec1;
            initRandom(out vec1);
            Console.WriteLine(vec1);
            
            Console.Write("ref (нормирование вектора): \n\t");
            Vector2 vec2 = new Vector2(153,40);
            normalize(ref vec2);
            Console.WriteLine(vec2);

            Pause();

            System.Console.WriteLine("Перегрузка операторов '+', '++':");
            Console.WriteLine("vec2 = " + vec2);
            Console.WriteLine("++vec2 = " + ++vec2);
            Console.WriteLine("vec2 = " + vec2);
            Console.WriteLine("vec2++ = " + vec2++);
            Console.WriteLine("vec2 = " + vec2);
            Console.WriteLine("vec2 + vec2 = " + (vec2+vec2));

            Pause();

            System.Console.Write("Обработка строк (Вытаскиваем свойства из Vector2.ToString()): \n\t");

            String str = vec2.ToString();
            str = str.Substring(str.IndexOf(" "), str.Length-str.IndexOf(" "));
            str = new String(str.Where(c => !"<>()".Contains(c)).ToArray());
            String[] props = str.Split(", ").Select((prop) => prop.Trim()).ToArray();
            Array.Reverse(props);
            System.Console.WriteLine("Props: ["+string.Join("] [", props)+"]");
            
            

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