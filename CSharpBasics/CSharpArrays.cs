using System;
namespace CSharpBasics
{
    public class CSharpArrays
    {
        public CSharpArrays()
        {
            byte[] bytearray;

            bytearray = new byte[2];

            bytearray[0] = 245;

            var AnotherArray = new int[] { 1, 2, 3, 4, 5 };

            double[,] DArray = { { 2.31, 2.45 } };

            DArray[0, 1] = 4.78;

            //Console.WriteLine(AnotherArray.Length);
            //Console.WriteLine(DArray);
        }
    }
}
