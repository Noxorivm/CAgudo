using System;


namespace Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            //Conversión explícita
            double miDouble = 13.37;
            int miInt;

            miInt = (int)miDouble;

            //Conversión implicita 

            int num = 123456;
            long numg = num;

            float miFloat = 13,37F;
            double miNuevoDouble = miFloat;

            //Conversión de tipo
            string miString = miDouble.ToString();

            Console.WriteLine(miString);
            Console.Read();

        }
    }
}
