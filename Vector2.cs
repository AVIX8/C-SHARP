using System;

namespace nsp
{
    public class Vector2
    {
        double x_ = 0;
        double y_ = 0;
        Color color_ = new Color(255, 255, 255);

        public double x
        {
            get { return x_; }
            set { x_ = value; }
        }
        public double y {
            get { return y_; }
            set { y_ = value; }
        }
        public Color color
        {
            get { return color_; }
            set { color_ = value; }
        }

        public Vector2() { }

        public Vector2(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public Vector2(double x, double y, Color color)
        {
            this.x = x;
            this.y = y;
            this.color = color;
        }

        public void init(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public void setColor(Color color)
        {
            this.color = color;
        }

        public void read()
        {
            while (true)
            {
                Console.Write("Enter x and y: ");
                try
                {
                    string[] a = Console.ReadLine().Split();
                    x = Double.Parse(a[0]);
                    y = Double.Parse(a[1]);
                    break;
                }
                catch (Exception e)
                {
                    Console.Write("[!] You have entered incorrect data, please try again.\n");
                }
            }
        }

        public double length
        {
            get
            {
                return Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
            }
        }

        public override string ToString()
        {
            return $"<Vector2 (x:{x}, y:{y}), length: {length}, color: \u001B[48;2;{color.r};{color.g};{color.b}m   \u001B[0m>";
        }

        public void display()
        {
            Console.WriteLine(this);
        }

        public double scalar(Vector2 otherVector)
        {
            return x * otherVector.x + y * otherVector.y;
        }

        public double angle(Vector2 otherVector)
        {
            double ang = Math.Acos(scalar(otherVector) / length / otherVector.length) / Math.PI * 180;
            return Math.Min(ang, 360 - ang);
        }

        public static Vector2 operator +(Vector2 v1, Vector2 v2)
        {
            return new Vector2(v1.x + v2.x, v1.y + v2.y);
        }

        public static Vector2 operator ++(Vector2 v)
        {
            double len = v.length;
            return new Vector2(v.x + v.x / len, v.y + v.y / len);
        }
    }
}