using System;
namespace CSharpBasics
{
    public class CSharpNumbers
    {
        public CSharpNumbers()
        {
            sbyte Age = 127;
            var ANumber = 38.344637892;
            float ThisIsAFloat = 2.31f;
            double ThisIsADouble = 2.31;

            double CastFloat = ThisIsAFloat;
            float CastDouble = Convert.ToSingle(ThisIsADouble);

            //Console.WriteLine(Age.GetType());
            //Console.WriteLine(ANumber.GetType());
            //Console.WriteLine(ThisIsAFloat.GetType());
            //Console.WriteLine(ThisIsADouble.GetType());
            Console.WriteLine(CastFloat);
            Console.WriteLine(CastDouble);

        }
    }
}
