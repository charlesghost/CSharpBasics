using System;
using System.Collections.Generic;
namespace CSharpBasics
{
    public class CSharpDictionary
    {
        public CSharpDictionary()
        {
            Dictionary<int, List<object>> TheMadDictionary = new Dictionary<int, List<object>>()
            {
                {1, new List<object>(){1, 2, 3}}
            };


        }
    }
}
