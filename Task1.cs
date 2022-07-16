namespace Program
{
    public class Task1
    {
        static void Main(string[] args)
        {
        }

        public static void ReplaceFirstWay(ref int X, ref int Y, ref int Z)
        {
            (X, Y, Z) = (Y, Z, X);
        }

        public static void ReplaceSecondWay(ref int X, ref int Y, ref int Z)
        {
            Y = X + Y + Z;

            X = Y - (X + Z);
            Z = Y - (X + Z);
            Y = Y - (X + Z);
        }
    }
}