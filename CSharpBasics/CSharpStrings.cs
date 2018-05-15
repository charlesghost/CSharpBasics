using System;

namespace KCCSharpBasics
{
    public class CSharpStrings
    {
        public CSharpStrings()
        {
            //var Name =  "Jimmy";
            //string AnotherName = "Bill";
            //String Name1 = "test";
            //System.String name2 = "test2";

            string fname, lname;

            fname = "Charles";
            lname = "Joshua";

            Console.WriteLine(fname + " " + lname);

            var x = fname.Contains("sa");


            string interp1 = $"anything {fname}";


        }

        public void interp2(string name)
        {
            Console.WriteLine("string -> {0}", name);
        }
    }
}
