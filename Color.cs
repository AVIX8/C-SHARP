namespace nsp
{
    public class Color
    {
        public static Color red{ get{ return new Color(255,0,0); } }
        public static Color green{ get{ return new Color(0,255,0); } }
        public static Color blue{ get{ return new Color(0,0,255); } }

        private int r;
        private int g;
        private int b;

        public Color()
        {
            this.r = 255;
            this.g = 255;
            this.b = 255;
        }

        public Color(int r, int g, int b)
        {
            this.r = r;
            this.g = g;
            this.b = b;
        }

        public override string ToString()
        {
            return $"\u001B[48;2;{r};{g};{b}m   \u001B[0m";
        }
    }
}