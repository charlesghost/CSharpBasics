using System;
using System.Collections.Generic;
namespace CSharpBasics
{
    public class CSharpLists
    {
        public CSharpLists()
        {
            List<int> numbers = new List<int>
            {
                1,
                2,
                3,
                4
            };

            numbers.Add(6);

            List<string> Names = new List<string> { "Jenny", "Stephen" };

            Names.Add(1.ToString());

            List<object> ExampleObjects = new List<object> { 1, 2, true, "stringEx" };


            //for (int i = 0; i < numbers.Count; i++)
            //{
            //  var x = i;
            //}

            //         foreach (var item in numbers)
            //{
            //  var y = item;
            //}

        }
    }
}
